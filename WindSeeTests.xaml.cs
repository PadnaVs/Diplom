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
using System.Windows.Shapes;
using Diplom_V4.src;

namespace Diplom_V4.src
{
    /// <summary>
    /// Логика взаимодействия для WindSeeTests.xaml
    /// </summary>
    public partial class WindSeeTests : Window
    {
        public LoadTest testSel; 
        public WindSeeTests()
        {
            InitializeComponent();
            DataContext = App.data;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            App.netControl.getAllTests();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            testSel = (LoadTest)testTab.SelectedItem;
           
            if (App.netControl.currentUser.id != testSel.Creater.id)
            {
                MessageBox.Show( "Этот тест вам не пренадлежит!", "Вы выбрали не вашь тест!", MessageBoxButton.OK, MessageBoxImage.Information );
            } 
            else if( testSel == null )
            {
                MessageBox.Show("Вы не выбрали тест!", "Выберите тест!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else 
            {
                //App.data.TestsLoaded.Remove(testSel);
                App.netControl.delSelectTest(App.netControl.currentUser.id, testSel.Name);
                App.netControl.getAllTests();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            testSel = (LoadTest)testTab.SelectedItem;
            if (testSel == null)
            {
                MessageBox.Show("Вы не выбрали тест!", "Выберите тест!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if (App.netControl.currentUser.id != testSel.Creater.id)
            {
                MessageBox.Show("Этот тест вам не пренадлежит!", "Вы выбрали не вашь тест!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MainWindow.windSeeSelTest = new WindSeeSelTest();
                MainWindow.windSeeSelTest.Show();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            App.netControl.getAllTests();
        }
    }
}
