using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

using System.Collections.ObjectModel;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Diplom_V4.src;

namespace Diplom_V4
{
    /// <summary>
    /// Логика взаимодействия для CreateTestPage.xaml
    /// </summary>
    public partial class CreateTestPage : Page
    {
        //private List<TaskTest> _tasks = new List<TaskTest>(); 
        
        private TaskModel _dataTest = new TaskModel() { Tasks = new ObservableCollection<TaskTest>() };
        private string    _nameTest = null;
        public CreateTestPage()
        {
            InitializeComponent();
            DataContext = _dataTest;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.windCreateQuestion = new WindCreateQuestion();
            MainWindow.windCreateQuestion.Show();
        }

        public void addTask( TaskTest task ) 
        {
            _dataTest.Tasks.Add( task );
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (tasksTest.SelectedIndex == -1) return;
            _dataTest.Tasks.RemoveAt(tasksTest.SelectedIndex);

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string js = JsonConvert.SerializeObject(_dataTest.Tasks);

            if (_nameTest == "" || _nameTest == null) {
                MessageBox.Show( "Введите название теста", "Не введенно название!", MessageBoxButton.OK, MessageBoxImage.Information );
                return;
            }

            if ( js == "" || js == null )
            {
                MessageBox.Show("Нет вопросов в тесте! Добавьте их.", "Не введенны поросы!", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            App.netControl.checkCreateTest( _nameTest, js );

        }

        private void testName_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox newT = (TextBox)sender;
            _nameTest = newT.Text;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MainWindow.windSeeTests = new WindSeeTests();
            MainWindow.windSeeTests.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            
            if (MainWindow.windCreateQuestion != null && MainWindow.windCreateQuestion.IsVisible) 
            {
                MainWindow.windCreateQuestion.Close();
            }

            if (MainWindow.windSeeTests != null && MainWindow.windSeeTests.IsVisible)
            {
                MainWindow.windSeeTests.Close();
            }
            MainWindow.frame.Navigate(MainWindow.mainPage);

        }
    }
}
