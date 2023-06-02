using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectOpp;

public class LoginValidator : IValidator<string>
{
    public ValidationResult IsValid(string login)
    {
        if (string.IsNullOrEmpty(login))
            return new ValidationResult(false, "Login is null or empty");

        if (login.Length < 4)
            return new ValidationResult(false, "Login length less then 4");

        var englishValidator = new EnglishValidator();

        if (!englishValidator.IsValid(login))
            return new ValidationResult(false, "Login must contains only latin letters, digits and backspaces");

        return new ValidationResult(true);
    }
}
