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
            if (c is >= 'a' and <= 'z' 
                or >= 'A' and <= 'Z' 
                or >= '0' and <= '9' 
                or '_') 
            {
                continue;
            }

            return new ValidationResult(false, "String must contains only latin letters, digits and underscores");
        }

        return new ValidationResult(true);
    }
}
