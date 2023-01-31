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

namespace Diplom_V4
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            this.ShowsNavigationUI = false;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            App.netControl.currentUser = new User();
            MainWindow.inputedUser = false;
        }

        private void butReg_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.frame.Navigate(MainWindow.registerPage);
        }

        private void butInputTeacher_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.currentUser = "Преподаватель";
            MainWindow.frame.Navigate(MainWindow.inputPage);
        }

        private void butInputStudent_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.currentUser = "Студент";
            MainWindow.frame.Navigate(MainWindow.inputPage);
        }
    }
}
