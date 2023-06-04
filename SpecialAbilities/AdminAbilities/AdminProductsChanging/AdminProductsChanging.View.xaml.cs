using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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

    private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
    {
        int size = 30;
        int strCount = 12;

        if (sender is TextBox textBox)
        {
            var lines = new string[strCount + 5];
            GetLines(textBox).CopyTo(lines, 0);

            var t = textBox.Text;

            int l = lines.Length;
            int len = 0;

            for (int i = 0; i < l; i++)
            {
                if (lines[i] is null)
                    continue;

                if (i >= strCount && lines[i] != "")
                {
                    textBox.Text = textBox.Text[0..len];
                    textBox.Select(len - 2, 0);
                    break;
                }

                if (lines[i].Length > size && lines[i][size] != '\n' && lines[i][size] != '\r')
                {
                    var newText = textBox.Text.Remove(len + size, 1);
                    

                    
                    textBox.Text = newText;
                    textBox.Select(len + size, 0);
                    break;
                }

                len += lines[i].Length;
            }

            if (textBox.DataContext is ProductModel productModel)
            {
                productModel.Description = textBox.Text;
            }
        }
    }

    StringCollection GetLines(TextBox textBox)
    {
        StringCollection lines = new StringCollection();

        // lineCount may be -1 if TextBox layout info is not up-to-date.
        int lineCount = textBox.LineCount;

        for (int line = 0; line < lineCount; line++)
            // GetLineText takes a zero-based line index.
            lines.Add(textBox.GetLineText(line));

        return lines;
    }
}
