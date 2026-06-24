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
        var bag = await Pipeline.From<ReadJsonFile, ParseSifComponents, CreateSifParseResult>().Run(new { filePath, configFunctionApi = new ConfigFunctionApi(), sifJsonParser = this, visitedFiles });

        return bag.ResultOrThrow<SifJsonParsingResult>();
    }

    public async Task<SifJsonParsingResult> ParseContent(string jsonContent)
    {
        var bag = await Pipeline.From<ReadJsonText, ParseSifComponents, CreateSifParseResult>().Run(new { jsonContent, configFunctionApi = new ConfigFunctionApi(), sifJsonParser = this, visitedFiles = Array.Empty<string>() });

        return bag.ResultOrThrow<SifJsonParsingResult>();
    }

    public async Task<SifJsonParsingResult> ParseUrl(string url)
    {
        var bag = await Pipeline.From<ReadUrlContent, ParseSifComponents, CreateSifParseResult>().Run(new { url, configFunctionApi = new ConfigFunctionApi(), sifJsonParser = this, visitedFiles = Array.Empty<string>() });

        return bag.ResultOrThrow<SifJsonParsingResult>();
    }
}