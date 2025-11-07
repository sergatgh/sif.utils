namespace SIF.Utils;

public class ParameterEditModel
{
    public string Name { get; set; } = string.Empty;

    public string? DefaultValue { get; set; }

    public string Value { get; set; } = string.Empty;

    public bool HasDefaultValue { get; set; }

    public bool IsReference { get; set; }

    public bool HasValidation { get; set; }

    public string GetErrorText(string? newValue = null)
    {
        if (!IsReference && !HasDefaultValue && string.IsNullOrWhiteSpace(newValue ?? Value))
        {
            return "Value is required for parameters without default value or reference.";
        }
        return string.Empty;
    }

    public static ParameterEditModel FromSifJsonParameterModel(SifJsonParameterModel model)
    {
        return new ParameterEditModel
        {
            Name = model.Name,
            Value = model.DefaultValue,
            DefaultValue = string.IsNullOrWhiteSpace(model.DefaultValue) ? null : model.DefaultValue,
            HasDefaultValue = !string.IsNullOrWhiteSpace(model.DefaultValue),
            IsReference = !string.IsNullOrWhiteSpace(model.Reference),
            HasValidation = !string.IsNullOrWhiteSpace(model.Validate)
        };
    }
}