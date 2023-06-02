using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectOpp;

public interface IValidator<T>
{
    ValidationResult IsValid(T value);
}
