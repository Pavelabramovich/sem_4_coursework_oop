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

/// <summary>
/// Логика взаимодействия для TestPage.xaml
/// </summary>
/// 

public partial class LoginPage : Page
{
    private MainWindow _mainWindow;

    private UserDb _userDb;

    private string Password
    {
        get
        {
            if (PasswordHidden.Visibility == Visibility.Visible)
            {
                return PasswordHidden.Password;
            }
            else
            {
                return PasswordUnmask.Text;
            }
        }
    }

    public LoginPage(MainWindow mainWindow)
    {
        InitializeComponent();

        _mainWindow = mainWindow;
        _userDb = UserDb.Instance;
    }

    private void Button_Click_1(object sender, RoutedEventArgs e)
    {
        string login = loginTextBox.Text;
        string password = Password;

        var user = _userDb.Users.FirstOrDefault(u => u.Login == login);

        if (user != null)
        {
            if (user.Password == password)
            {
                _mainWindow.OpenSecondPage();
            }
            else
            {
                invalidPasswordLabel.Content = "Invalid password";
            }
        }
        else
        {
            invalidLoginLabel.Content = "Invalid login";
        }
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        _mainWindow.OpenSecondPage();
    }

    private void ClearLabels()
    {
        invalidLoginLabel.Content = string.Empty;
        invalidPasswordLabel.Content = string.Empty;
    }
    //private void ShowPassword_PreviewMouseDown(object sender, MouseButtonEventArgs e) => ShowPasswordFunction();
    //private void ShowPassword_PreviewMouseUp(object sender, MouseButtonEventArgs e) => HidePasswordFunction();
    //private void ShowPassword_MouseLeave(object sender, MouseEventArgs e) => HidePasswordFunction();

    private void ShowPasswordFunction()
    {
        //ShowPassword.Text = "HIDE";
        PasswordUnmask.Visibility = Visibility.Visible;
        PasswordHidden.Visibility = Visibility.Collapsed;

        if (PasswordHidden.Password != PasswordUnmask.Text)
            PasswordUnmask.Text = PasswordHidden.Password;
    }

    private void HidePasswordFunction()
    {
       // ShowPassword.Text = "SHOW";
        PasswordUnmask.Visibility = Visibility.Collapsed;
        PasswordHidden.Visibility = Visibility.Visible;

        if (PasswordHidden.Password != PasswordUnmask.Text)
            PasswordHidden.Password = PasswordUnmask.Text;
    }

    private void hidePasswordCheckBox_Checked(object sender, RoutedEventArgs e)
    {
        ShowPasswordFunction();
    }

    private void hidePasswordCheckBox_Unchecked(object sender, RoutedEventArgs e)
    {
       
        HidePasswordFunction();
    }

    private void PasswordHidden_PreviewTextInput(object sender, TextCompositionEventArgs e)
    {
        ClearLabels();
    }

    private void PasswordUnmask_PreviewTextInput(object sender, TextCompositionEventArgs e)
    {
        ClearLabels();
    }
}
