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

        if (password.Count() < 10)
            return new ValidationResult(false, "Password length less then 10");

        var englishValidator = new EnglishValidator();

        if (!englishValidator.IsValid(password))
            return new ValidationResult(false, "Password must contains only latin letters, digits and underscores");

        try
        {
            (int upper, int lower, int digits) = CountSymbolsType(password);

            if (upper < 2)
                return new ValidationResult(false, "Password must contains minimal 2 uppercase letters");

            if (lower < 2)
                return new ValidationResult(false, "Password must contains minimal 2 lowercase letters");

            if (digits < 2)
                return new ValidationResult(false, "Password must contains minimal 2 digits letters");

            return new ValidationResult(true);
        }
        catch
        {
            return new ValidationResult(false, "Password must contains only latin letters, digits and underscores");
        }
    }

    private (int, int, int) CountSymbolsType(IEnumerable<char> password)
    {
        int upper = 0;
        int lower = 0;
        int digits = 0;

        foreach (char c in password)
        {
            switch (c)
            {
                case >= 'a' and <= 'z':
                    lower++;
                    break;
                case >= 'A' and <= 'Z':
                    upper++;
                    break;
                case >= '0' and <= '9':
                    digits++;
                    break;
                default:
                    throw new ArgumentException("Invalid symbols in the password");
            }
        }

        return (upper, lower, digits);
    }
}