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
/// Логика взаимодействия для TestPage2.xaml
/// </summary>
public partial class MainPage : UserControl
{
   // private MainWindow _mainWindow;

    public MainPage()
    {
        InitializeComponent();

        DataContext = new MainPageViewModel("");  
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        //_mainWindow.OpenFirstPage();

        //var db = UserDb.Instance;
    }
}
