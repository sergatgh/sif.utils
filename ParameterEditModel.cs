using System.ComponentModel;

namespace SIF.Utils;

using System.Runtime.CompilerServices;
using SIF.Utils.JsonParser;

public class ParameterEditModel : INotifyPropertyChanged
{
    public string Name { get; set; } = string.Empty;

    public string? DefaultValue { protected get; set; }

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
            Value = model.DefaultValue ?? string.Empty,
            DefaultValue = model.DefaultValue,
            HasDefaultValue = model.DefaultValue is not null,
            IsReference = model.Reference is not null,
            HasValidation = model.Validate is not null
        };
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    public virtual bool IsDefaultValueSet()
    {
        return HasDefaultValue && Value == DefaultValue;
    }

    public void ResetToDefault()
    {
        if (!HasDefaultValue || Value == DefaultValue) return;

        Value = DefaultValue ?? string.Empty;
    }
}