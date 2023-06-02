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


public partial class AdminProductsChangingView : UserControl
{
    public AdminProductsChangingView() => InitializeComponent();

    private void btnOpen_Click(object sender, RoutedEventArgs e)
    {
        OpenFileDialog op = new OpenFileDialog();
        op.Title = "Select a picture";
        op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
          "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
          "Portable Network Graphic (*.png)|*.png";


        if (op.ShowDialog() == true)
        {
            string filePath = op.FileName;
             
            if (sender is Button btn && 
                btn.Parent is StackPanel stackPanel && 
                stackPanel.DataContext is ProductModel model)
            {
                model.ImagePath = filePath;
            }
        }
    }


    private void IntegerUpDown_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
    {
        //if (sender is IntegerUpDown upDown &&
        //    upDown.DataContext is TypeModel model)
        //{
        //    model.Discount = upDown.Value ?? 0;
        //}

        if (sender is IntegerUpDown upDown)
        {
            if (upDown.DataContext is TypeModel typeModel)
            {
                typeModel.Discount = upDown.Value ?? 0;
            }

            if (upDown.DataContext is ProductModel productModel)
            {
                productModel.Price = upDown.Value ?? 0;
            }
        }
    }
}
