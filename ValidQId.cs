namespace TinkeringApp;

using System.ComponentModel.DataAnnotations;
using System.Linq;

using System;

[AttributeUsage(AttributeTargets.Property)]
public class ValidQId : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        switch (value)
        {
            case null:
            case string valueAsString when valueAsString.All(char.IsDigit):
                return ValidationResult.Success;
            default:
                throw new Exception($"{validationContext.DisplayName} must be a numeric string");
        }
    }
}