﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace CourseProjectOpp;

public class LoginIsAdminConverter : IValueConverter
{
    public object Convert(object values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {

        return true;
    }

    public object ConvertBack(object value, Type targetTypes, object parameter, System.Globalization.CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
