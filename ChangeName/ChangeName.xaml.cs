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

public partial class ChangeNameBox : Window
{
    public ChangeNameBox()
    {
        InitializeComponent();
    }

    static IValidator<string> s_validator;

    static ChangeNameBox s_customMessageBox;
    static string? s_result = null;
    public ChangeNameBox messageTitle { get; set; }
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

   
    public static string? Show(string? message, IValidator<string>? validator)
    {
        s_customMessageBox = new ChangeNameBox();

        if (message is not null)
            s_customMessageBox.messageTextBlock.Text = message;

        if (validator is not null)
            s_validator = validator;

        s_customMessageBox.ShowDialog();

        return s_result;
    }

    private void BntCreate_Click(object sender, RoutedEventArgs e)
    {
        string newValue = newValueTextBox.Text;

        var res = s_validator.IsValid(newValue);

        if (!res)
        {
            invalidCardNumberLabel.Content = res.Message;
            return;
        }

        s_result = newValue;
        Border border = new Border();

        s_customMessageBox.Close();
    }

    private void BtnCancel_Click(object sender, RoutedEventArgs e)
    {
        s_result = null;
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
}
