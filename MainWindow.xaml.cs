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
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private LoginPage _testPage;
    private MainPage _testPage2;

    public MainWindow()
    {
        InitializeComponent();


        var viewModel = new MainWindowViewModel();

        DataContext = viewModel;
        //_testPage = new LoginPage(this);
        //_testPage2 = new MainPage(this);

        //OpenFirstPage();
    }

    private void OpenPage(Page page)
    {
        //frame.Navigate(page);     
    }

    internal void OpenFirstPage()
    {
       // OpenPage(_testPage);
    }

    internal void OpenSecondPage()
    {
       // OpenPage(_testPage2);
    }

    // Password verify button
    internal void Button_Click_1(object sender, RoutedEventArgs e)
    {
        //Random rnd = new Random();

        //int r = rnd.Next(0,2);

        //if (r == 0)
        //    OpenPages(pages.login);
        //else
        //    OpenPages(pages.regin);
    }

}
