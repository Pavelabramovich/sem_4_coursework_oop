using MaterialDesignThemes.Wpf;
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

public partial class CustomMessageBox : Window
{
    public CustomMessageBox()
    {
        InitializeComponent();
    }
    static CustomMessageBox s_customMessageBox;
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
    public static DialogResult Show(string top, string message, CMessageTitle title, CMessageButton okButton)
    {
        s_customMessageBox = new CustomMessageBox();
        s_customMessageBox.btnOk.Content = s_customMessageBox.GetButtonText(okButton);
   
        s_customMessageBox.txtMessage.Text = message;
        s_customMessageBox.txtTitle.Text = top;


        switch (title)
        {
            case CMessageTitle.Error:
                s_customMessageBox.msgLogo.Kind = PackIconKind.Error;
                s_customMessageBox.msgLogo.Foreground = Brushes.DarkRed;
                break;
            case CMessageTitle.Info:
                s_customMessageBox.msgLogo.Kind = PackIconKind.InfoCircle;
                s_customMessageBox.msgLogo.Foreground = Brushes.Blue;
                s_customMessageBox.btnCancel.Visibility = Visibility.Collapsed;
                s_customMessageBox.btnOk.SetValue(Grid.ColumnSpanProperty, 2);
                break;
            case CMessageTitle.Warning:
                s_customMessageBox.msgLogo.Kind = PackIconKind.Warning;
                s_customMessageBox.msgLogo.Foreground = Brushes.Yellow;
                s_customMessageBox.btnCancel.Visibility = Visibility.Collapsed;
                s_customMessageBox.btnOk.SetValue(Grid.ColumnSpanProperty, 2);
                break;
            case CMessageTitle.Confirm:
                s_customMessageBox.msgLogo.Kind = PackIconKind.QuestionMark;
                s_customMessageBox.msgLogo.Foreground = Brushes.Gray;
                break;
        }
        s_customMessageBox.ShowDialog();
        return result;
    }

    private void BntOk_Click(object sender, RoutedEventArgs e)
    {
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
}
