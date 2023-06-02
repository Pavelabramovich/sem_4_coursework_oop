using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectOpp;

public static class BoolExtension
{
    public static bool Not(this Boolean? value)
    {
        return (!value) ?? true;
    }
}
