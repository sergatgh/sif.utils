namespace SIF.Utils.Logic.JsonParser;

using AutoPipe;
using SIF.Utils.Logic.ConfigFunctionParser;
using SIF.Utils.Logic.JsonParser.ParseFile;

public interface ISifJsonParser
{
    Task<SifJsonParsingResult> Parse(string filePath, string[] visitedFiles);
    Task<SifJsonParsingResult> Parse(string filePath);
}

public class SifJsonParser : ISifJsonParser
{
    public Task<SifJsonParsingResult> Parse(string filePath)
    {
        return Parse(filePath, []);
    }

    public async Task<SifJsonParsingResult> Parse(string filePath, string[] visitedFiles)
    {
        var bag = await Pipeline.From<ReadJsonObject, ParseSifComponents>().Run(new { filePath, configFunctionApi = new ConfigFunctionApi(), sifJsonParser = this, visitedFiles });

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