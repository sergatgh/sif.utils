using System.Text.Json.Nodes;

namespace SIF.Utils.Forms.JsonBuilder.Register;

public class RegisterMethodModel
{
    public string PowershellFunction { get; set; } = string.Empty;

    public string RegisterAs { get; set; } = string.Empty;
}