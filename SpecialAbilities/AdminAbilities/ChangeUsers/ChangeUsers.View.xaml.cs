using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
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
    public ChangeUsersView()
    {
        InitializeComponent();
    }



    private void IntegerUpDown_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
    {
        if (sender is IntegerUpDown upDown &&
            upDown.DataContext is UserModel model)
        {
            model.Discount = upDown.Value ?? 0;
        }
    }

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
                stackPanel.DataContext is UserModel model)
            {
                model.AvatarPath = filePath;
            }
        }
    }


    //public IEnumerable<DataGridRow> GetDataGridRows(DataGrid grid)
    //{
    //    var itemsSource = grid.ItemsSource;

    //    if (itemsSource is null) 
    //        yield return null;

    //    foreach (var item in itemsSource)
    //    {
    //        var row = grid.ItemContainerGenerator.ContainerFromItem(item) as DataGridRow;

    //        if (row is not null) 
    //            yield return row;
    //    }
    //}
}
