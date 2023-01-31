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
    /// Логика взаимодействия для StartPageTeacher.xaml
    /// </summary>
    public partial class StartPageTeacher : Page
    {
        public StartPageTeacher()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            lbNT.Content = "\n " + App.netControl.currentUser.name + " " + App.netControl.currentUser.lasnName+"!";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.frame.Navigate(MainWindow.createTestPage);
        }
    }
}
