using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UserControl = System.Windows.Controls.UserControl;

namespace CourseProjectOpp;

public partial class ProductsView : UserControl
{
    public ProductsView() => InitializeComponent();


    public void CreateOrder(object sender, RoutedEventArgs e)
    {
        if (DataContext is not null and ProductsViewModel viewModel && viewModel.IsAnonymous)
        {
            DialogResult res = CustomMessageBox.Show(
              "Warning",
              "Please login first",
              CustomMessageBox.CMessageTitle.Warning,
              CustomMessageBox.CMessageButton.Ok);

            return;
        }
    }
}

