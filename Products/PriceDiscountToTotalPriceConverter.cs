using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace CourseProjectOpp;

public class PriceDiscountToTotalPriceConverter : IMultiValueConverter
{
    public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        if (values.Length == 3)
        {
            int price = (int)values[0];
            int productDiscount = (int)values[1];
            int userDiscount = (int)values[2];

            return $"${(int)(price - (double)price * productDiscount / 100.0 - (double)price * userDiscount / 100.0)}";
        }
        else
            return string.Empty;
    }

    public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
