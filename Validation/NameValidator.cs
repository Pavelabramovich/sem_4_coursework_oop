using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectOpp;

public class NameValidator : IValidator<string>
{
    public ValidationResult IsValid(string login)
    {
        if (string.IsNullOrEmpty(login))
            return new ValidationResult(false, "Name is empty");

        if (login.Length < 4)
            return new ValidationResult(false, "Name length less then 4");

        if (login.Length > 20)
            return new ValidationResult(false, "Name length greather then 20");

        var englishValidator = new EnglishValidator();

        if (!englishValidator.IsValid(login))
            return new ValidationResult(false, "Name must contains only latin letters, digits and underscores");

        return new ValidationResult(true);
    }
}
