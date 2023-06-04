using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace CourseProjectOpp;

public class DiscountsToIconConverter : IMultiValueConverter
{
    public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        if (values.Length == 2)
        {
            int productDiscount = (int)values[0];
            int userDiscount = (int)values[1];

            if (productDiscount + userDiscount == 0)
            {
                return "FireExtinguisher";
            }

            return "Fire";
        }
        else
            return "FireExtinguisher";
    }

    public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
