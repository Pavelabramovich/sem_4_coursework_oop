using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectOpp;

public class NewProductNameValidator : IValidator<string>
{
    public ValidationResult IsValid(string newProductName)
    {
        if (string.IsNullOrEmpty(newProductName))
            return new ValidationResult(false, "Name is empty");

        if (newProductName.Length < 4)
            return new ValidationResult(false, "Name length less then 4");

        if (newProductName.Length > 20)
            return new ValidationResult(false, "Name length greather then 20");

        var englishValidator = new EnglishValidator();

        if (!englishValidator.IsValid(newProductName))
            return new ValidationResult(false, "Name must contains only latin letters, digits and underscores");

        var productDb = ProductsDb.Instance;

        var matches = productDb.Products.Where(p => p.Name == newProductName).Count();

        if (matches > 0)
        {
            return new ValidationResult(false, "Product with this name already exists");
        }

        return new ValidationResult(true);
    }
}
