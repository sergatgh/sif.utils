namespace SIF.Utils.Logic.JsonParser;

using AutoPipe;
using SIF.Utils.Logic.ConfigFunctionParser;
using SIF.Utils.Logic.JsonParser.ParseFile;

public interface ISifJsonParser
{
    Task<SifJsonParsingResult> Parse(string filePath, string[] visitedFiles);
    Task<SifJsonParsingResult> Parse(string filePath);
    Task<SifJsonParsingResult> ParseContent(string jsonContent);
    Task<SifJsonParsingResult> ParseUrl(string url);
}

public class SifJsonParser : ISifJsonParser
{
    public Task<SifJsonParsingResult> Parse(string filePath)
    {
        return Parse(filePath, []);
    }

    public async Task<SifJsonParsingResult> Parse(string filePath, string[] visitedFiles)
    {
        var bag = await Pipeline.From<ReadJsonFile, ParseSifComponents>().Run(new { filePath, configFunctionApi = new ConfigFunctionApi(), sifJsonParser = this, visitedFiles });

        return MapResult(bag);
    }

    public async Task<SifJsonParsingResult> ParseContent(string jsonContent)
    {
        var bag = await Pipeline.From<ReadJsonText, ParseSifComponents>().Run(new { jsonContent, configFunctionApi = new ConfigFunctionApi(), sifJsonParser = this, visitedFiles = Array.Empty<string>() });

        return MapResult(bag);
    }

    public async Task<SifJsonParsingResult> ParseUrl(string url)
    {
        var bag = await Pipeline.From<ReadUrlContent, ParseSifComponents>().Run(new { url, configFunctionApi = new ConfigFunctionApi(), sifJsonParser = this, visitedFiles = Array.Empty<string>() });

        return MapResult(bag);
    }

    public virtual SifJsonParsingResult MapResult(Bag bag)
    {
        if (bag.HasErrors())
        {
            return new SifJsonParsingResult
            {
                Error = bag.Summary(filter: MessageFilter.Error),
                IsRawJson = true,
            };
        }

        var result = new SifJsonParsingResult { IsRawJson = true };

        if (bag.HasWarnings())
        {
            result.Warnings.AddRange(bag.Warnings());
        }

        bag.Update(result);
        return result;
    }
}