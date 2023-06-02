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

namespace CourseProjectOpp;

public partial class ProductsView : UserControl
{
    public ProductsView() => InitializeComponent();

    public void AnonymousWarning(object sender, RoutedEventArgs e)
    {
        if (DataContext is not null and ProductsViewModel viewModel && viewModel.IsAnonymous)
        {
            MessageBox.Show("Please login first", "Warning", MessageBoxButton.OK);
        }
    }
}

