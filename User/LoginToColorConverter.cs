using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace CourseProjectOpp;

class LoginToColorConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is not String login)
            throw new ArgumentException($"Value is not int, but a {value.GetType().Name}");

        Random rand = new Random(login.Length + login[1] * login[2]);

        return $"#{rand.Next(100000, 999999)}";
    }
    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is not String str)
            throw new ArgumentException($"Value is not string, but a {value.GetType().Name}");

        throw new NotImplementedException();
    }
}
