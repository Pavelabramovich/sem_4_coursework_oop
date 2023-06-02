using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Xceed.Wpf.Toolkit;

namespace CourseProjectOpp;

public partial class ChangeUsersView : UserControl
{
    public ChangeUsersView() => InitializeComponent();



    private void IntegerUpDown_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
    {
        if (sender is IntegerUpDown upDown &&
            upDown.DataContext is UserModel model)
        {
            model.Discount = upDown.Value ?? 0;
        }
    }
}
