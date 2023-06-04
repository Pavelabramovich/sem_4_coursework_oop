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

namespace CourseProjectOpp;


public partial class UserView : System.Windows.Controls.UserControl
{
    public UserView() => InitializeComponent();


    public void AnonymousWarning(object sender,  RoutedEventArgs e)
    {
        if (DataContext is not null and UserViewModel viewModel && viewModel.IsAnonymous)
        {
            DialogResult res = CustomMessageBox.Show(
                "Warning",
                "Please login first",      
                CustomMessageBox.CMessageTitle.Warning, 
                CustomMessageBox.CMessageButton.Ok);
        }     
    }
}
