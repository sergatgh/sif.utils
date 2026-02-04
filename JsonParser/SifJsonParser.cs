namespace SIF.Utils.JsonParser;

using AutoPipe;
using SIF.Utils.JsonParser.ParseFile;

public class SifJsonParser
{
    public async Task<SifJsonParsingResult> Parse(string filePath)
    {
        var bag = await Pipeline.From<ReadJsonObject, ParseSifComponents>().Run(new { filePath });
        
        if (bag.HasErrors())
        {
            return new SifJsonParsingResult
            {
                Error = bag.Summary(filter: MessageFilter.Error),
            };
        }

        var result = new SifJsonParsingResult();

        if (bag.HasWarnings())
        {
            result.Warnings.AddRange(bag.Warnings());
        }

        bag.Update(result);
        return result;
    }
}