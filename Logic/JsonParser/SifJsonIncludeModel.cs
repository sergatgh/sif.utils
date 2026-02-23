namespace SIF.Utils.Logic.JsonParser;

public class SifJsonIncludeModel : SifBaseProperties
{
    public string? OriginalValue { get; set; }
    public string? FullPath { get; set; }

    public SifJsonParsingResult? ParseResult { get; set; }
}