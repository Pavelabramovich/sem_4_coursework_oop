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

    public LoginPage(MainWindow mainWindow)
    {
        InitializeComponent();

        _mainWindow = mainWindow;
        _userDb = UserDb.Instance;
    }

    private void Button_Click_1(object sender, RoutedEventArgs e)
    {
        string login = loginTextBox.Text;
        string password = passwordTextBox.Password;

        if (_userDb.Users.FirstOrDefault(u => u.Login == login && u.Password == password) != null)
            _mainWindow.OpenSecondPage();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        _mainWindow.OpenSecondPage();
    }
}
