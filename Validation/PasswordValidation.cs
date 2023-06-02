using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectOpp;

public class PasswordValidator : IValidator<IEnumerable<char>>
{
    public ValidationResult IsValid(IEnumerable<char> password)
    {
        if (password is null)
            return new ValidationResult(false, "Password is null");

        if (password.Count() < 4)
            return new ValidationResult(false, "Password length less then 4");

        var englishValidator = new EnglishValidator();

        if (!englishValidator.IsValid(password))
            return new ValidationResult(false, "Password must contains only latin letters, digits and backspaces");

        return new ValidationResult(true);
    }
}