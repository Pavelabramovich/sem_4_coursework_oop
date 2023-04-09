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
using System.Security;

namespace CourseProjectOpp;

/// <summary>
/// Логика взаимодействия для TestPage.xaml
/// </summary>
/// 

public partial class LoginPage : Page
{
    private MainWindow _mainWindow;

    private UserDb _userDb;


    public LoginPage(MainWindow mainWindow)
    {
        InitializeComponent();

        DataContext = new LoginPageViewModel();

        _mainWindow = mainWindow;
        _userDb = UserDb.Instance;
    }

    private void Button_Click_1(object sender, RoutedEventArgs e)
    {
        string login = loginTextBox.Text;
        string password = PasswordHidden.Password;

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
}
