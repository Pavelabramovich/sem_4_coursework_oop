using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectOpp;

public readonly struct ValidationResult
{
    public bool IsValid { get; init; }

    public string? Message { get; init; }

    public ValidationResult(bool isValid)
    {
        IsValid = isValid;
        Message = null;
    }
    public ValidationResult(bool isValid, string message) 
    { 
        IsValid = isValid;
        Message = message;
    }

    public static implicit operator bool(ValidationResult validationResult)
    {
        return validationResult.IsValid;
    }
}
