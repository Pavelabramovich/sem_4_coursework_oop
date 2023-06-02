using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace CourseProjectOpp;

public class SecureStringToCharEnumerableConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is not IEnumerable<char> chars)
            throw new ArgumentException("Value must be IEnumerable<char>");

        SecureString ans = new();
        ans.AddRange(chars);

        return ans;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {


        if (value is not SecureString secureString)
            throw new ArgumentException("value must be SecureString");

        return secureString.ToCharSequance();
    }
}
