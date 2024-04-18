using MaterialDesignThemes.Wpf;
using Microsoft.VisualBasic.Logging;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Xceed.Wpf.Toolkit;

namespace CourseProjectOpp;

public partial class CreatingOrder : Window
{
    public CreatingOrder()
    {
        InitializeComponent();
    }

    static string s_login;
    static string s_productName;

    static CreatingOrder s_customMessageBox;
    static DialogResult result = System.Windows.Forms.DialogResult.No;
    public CMessageTitle messageTitle { get; set; }
    public enum CMessageButton
    {
        Ok,
        Yes,
        No,
        Cancel,
        Confirm

    }

    public string GetButtonText(CMessageButton value)
    {
        return Enum.GetName(typeof(CMessageButton), value);
    }

    public enum CMessageTitle
    {
        Error,
        Info,
        Warning,
        Confirm
    }
    public static void Show(string login, string productName)
    {
        s_customMessageBox = new CreatingOrder();

        s_login = login;
        s_productName = productName;

        s_customMessageBox.ShowDialog();
    }

    private void BntCreate_Click(object sender, RoutedEventArgs e)
    {
        string cardNumber = cardNumberTextBox.Text;

        if (cardNumber.Length != 10)
        {
            invalidCardNumberLabel.Content = "Card number must be 10 digits";
            return;
        }

        if (cardNumber.Where(c => char.IsDigit(c)).Count() != 10)
        {
            invalidCardNumberLabel.Content = "Card number must be 10 digits";
            return;
        }

        if (!ValidateCount())
            return;

        int count = countUpDown.Value ?? 1;
        var orderDb = OrdersDb.Instance;
        var productDb = ProductsDb.Instance;

        int pricePerOne = productDb.Products.Where(p => p.Name == s_productName).FirstOrDefault()?.Price ?? 0;
        int discount = productDb.Products.Where(p => p.Name == s_productName).FirstOrDefault()?.Discount ?? 0;

        pricePerOne -= (int)((double)pricePerOne * discount / 100);

        orderDb.Add(new Order 
        { 
            CustomerLogin = s_login, 
            ProductName = s_productName, 
            Count = count, 
            CardNumber = cardNumber, 
            DateTime=DateTime.Now, 
            PricePerOne= pricePerOne
        });

        result = System.Windows.Forms.DialogResult.Yes;
        Border border = new Border();

        s_customMessageBox.Close();
    }

    private void BtnCancel_Click(object sender, RoutedEventArgs e)
    {
        result = System.Windows.Forms.DialogResult.No;
        s_customMessageBox.Close();
    }

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
        Storyboard storyboard = new Storyboard();

        ScaleTransform scale = new ScaleTransform(1.0, 1.0);
        this.RenderTransformOrigin = new Point(0.5, 0.5);
        this.RenderTransform = scale;

        DoubleAnimation growAnimation = new DoubleAnimation();
        growAnimation.Duration = TimeSpan.FromMilliseconds(300);
        growAnimation.From = 0;
        growAnimation.To = 1;
        storyboard.Children.Add(growAnimation);

        Storyboard.SetTargetProperty(growAnimation, new PropertyPath("RenderTransform.ScaleX"));
        Storyboard.SetTarget(growAnimation, this);

        storyboard.Begin();
    }

    private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
    {

        Closing -= Window_Closing;
        e.Cancel = true;
        Storyboard storyboard = new Storyboard();

        ScaleTransform scale = new ScaleTransform(1.0, 1.0);
        this.RenderTransformOrigin = new Point(0.5, 0.5);
        this.RenderTransform = scale;

        DoubleAnimation growAnimation = new DoubleAnimation();
        growAnimation.Duration = TimeSpan.FromMilliseconds(300);
        growAnimation.From = 1;
        growAnimation.To = 0;
        storyboard.Children.Add(growAnimation);

        Storyboard.SetTargetProperty(growAnimation, new PropertyPath("RenderTransform.ScaleX"));
        Storyboard.SetTarget(growAnimation, this);
        growAnimation.Completed += GrowAnimation_Completed;

        storyboard.Begin();
    }

    private void GrowAnimation_Completed(object sender, EventArgs e)
    {
        this.Close();
    }

    private void Window_MouseDown(object sender, MouseButtonEventArgs e)
    {
        if (e.LeftButton == MouseButtonState.Pressed)
        {
            DragMove();
        }
    }

    private void cardNumberTextBox_TextChanged(object sender, TextChangedEventArgs e)
    {
        invalidCardNumberLabel.Content = "  ";
    }

    private bool ValidateCount()
    {
        string str = countUpDown.Text;

        if (str is null)
            return false;

        str = new string(str.Trim().Where(c => char.IsDigit(c)).ToArray());

        int value = int.Parse(str);

        if(value > 25)
        {
            str = "25";
        }

        if (value < 1)
        {
            str = "1";
        }

        if (countUpDown.Text != str)
            return false;

        return true;
    }
}
