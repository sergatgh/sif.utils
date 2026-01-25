namespace SIF.Utils.JsonParser;

public class SifJsonService
{
    public Task<SifJsonParsingResult> ParseJson(string? fileName = null)
    {
        return fileName == null
            ? Task.FromResult(new SifJsonParsingResult { Error = "File is not specified" })
            : new SifJsonParser().Parse(fileName);
    }
}