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

namespace Diplom_V4.pages
{
    /// <summary>
    /// Логика взаимодействия для StartPageStudent.xaml
    /// </summary>
    public partial class StartPageStudent : Page
    {
        public StartPageStudent()
        {
            InitializeComponent();
            DataContext = App.data;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int numSelTest = this.testTab.SelectedIndex;
            if (numSelTest == -1) 
            {
                MessageBox.Show( "Выберите тест из таблици, для прохождения!", "Выберите тест", MessageBoxButton.OK, MessageBoxImage.Information );
                return;
            }

            MainWindow.passingTestPage.numSelTest = numSelTest;
            MainWindow.frame.Navigate( MainWindow.passingTestPage );
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            this.lbNT.Content = App.netControl.currentUser.name + ' ' + App.netControl.currentUser.lasnName;
            App.netControl.getAllTests();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow.frame.Navigate(MainWindow.mainPage);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            App.netControl.getAllTests();
        }
    }
}
