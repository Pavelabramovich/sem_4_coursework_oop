using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CourseProjectOpp;

public class EnglishValidator : IValidator<IEnumerable<char>>
{
    public ValidationResult IsValid(IEnumerable<char> value)
    {
        foreach (char c in value)
        {
            if ( (c >= 'a' && c <= 'z') ||
                 (c >= 'A' && c <= 'Z') ||
                 (c >= '0' && c <= '9') ||
                 (c == '_') || (c == ' ') )
            {
                continue;
            }

            return new ValidationResult(false, "String must contains only latin letters, digits and underscores");
        }

        return new ValidationResult(true);
    }
}
