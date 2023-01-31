using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using Diplom_V4.src;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Linq;
using Newtonsoft.Json;

namespace Diplom_V4
{
    /// <summary>
    /// Логика взаимодействия для WindSeeSelTest.xaml
    /// </summary>
    public partial class WindSeeSelTest : Window
    {
        public TaskModel dataTest = new TaskModel();
        public TaskTest selTask;
        
        private ObservableCollection<TaskTest> _startTasks = new ObservableCollection<TaskTest>() { };
        private string _startNameTests = "";
        public WindSeeSelTest()
        {
            InitializeComponent();
            DataContext = dataTest;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dataTest.Tasks  = MainWindow.windSeeTests.testSel.Tasks;
            lbTestName.Text = MainWindow.windSeeTests.testSel.Name;
            setStartTasks(MainWindow.windSeeTests.testSel.Tasks);
            _startNameTests = String.Copy(MainWindow.windSeeTests.testSel.Name);
        }

        public void setStartTasks( ObservableCollection<TaskTest> tasks) 
        {
            for ( int i = 0; i < tasks.Count; i++) 
            {
                TaskTest nT = new TaskTest() { Name = tasks.ElementAt(i).Name, Answers = tasks.ElementAt(i).Answers, NumTrueAns = tasks.ElementAt(i).NumTrueAns };
                _startTasks.Add(nT);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool changedTasks = false;
            bool changedNameTest = false;

            if (MainWindow.windSeeTests.testSel.Name != _startNameTests) changedNameTest = true;

            for ( int i = 0; i < MainWindow.windSeeTests.testSel.Tasks.Count; i++ ) 
            {
                if (MainWindow.windSeeTests.testSel.Tasks.ElementAt(i).Name != _startTasks.ElementAt(i).Name) 
                {
                    changedTasks = true;
                }

                for (int j = 0; j < 4; j++) 
                {
                    if (MainWindow.windSeeTests.testSel.Tasks.ElementAt(i).Answers[j] != _startTasks.ElementAt(i).Answers[j]) 
                    {
                        changedTasks = true;
                        break;
                    }
                }
                if (changedTasks) break;
            }

            if (changedNameTest && !changedTasks)
            {
                App.netControl.updateTests(MainWindow.windSeeTests.testSel.Name, _startNameTests,  null);
            }
            else if (!changedNameTest && changedTasks)
            {
                string js = JsonConvert.SerializeObject(MainWindow.windSeeTests.testSel.Tasks);
                App.netControl.updateTests(_startNameTests, "", js);
            }
            else 
            {
                string js = JsonConvert.SerializeObject(MainWindow.windSeeTests.testSel.Tasks);
                App.netControl.updateTests(MainWindow.windSeeTests.testSel.Name, _startNameTests, js);
            }
            App.netControl.getAllTests();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            dataTest.Tasks.Clear();
            for (int i = 0; i < _startTasks.Count; i++)
            {
                dataTest.Tasks.Add(_startTasks.ElementAt(i));
            }
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if ( selTask == null ) 
            {
                MessageBox.Show( "Выберите вопрос который хотите изменить!", "Вы не выбрали вопрос!", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            MainWindow.windChangeSelTest = new WindChangeSelTest();
            MainWindow.windChangeSelTest.Show();
            MainWindow.windChangeSelTest.fillFiedls(selTask);
        }

        private void testTab_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (MainWindow.windChangeSelTest != null) MainWindow.windChangeSelTest.checkChanged();
            
            selTask = (TaskTest)testTab.SelectedItem;
            
            if (MainWindow.windChangeSelTest != null)
            {
                MainWindow.windChangeSelTest.setChangeTask(selTask);
                MainWindow.windChangeSelTest.fillFiedls(selTask);
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            MainWindow.windSeeSelTest = null;
        }

        public void saveTestName(string tNameChanged)
        {
            _startNameTests = tNameChanged;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MainWindow.windChangeNameSelTest = new WindChangeNameSelTest();
            MainWindow.windChangeNameSelTest.Show();
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            if (MainWindow.windChangeNameSelTest != null) MainWindow.windChangeNameSelTest.Close();
            if (MainWindow.windChangeSelTest != null)     MainWindow.windChangeSelTest.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (MainWindow.windCreateQuestion != null)
            {
                MainWindow.windCreateQuestion.Close();
                MainWindow.windCreateQuestion = null;
            }
            else {
                MainWindow.windCreateQuestion = new WindCreateQuestion();
                MainWindow.windCreateQuestion.Show();
            }
        }

        public void addTask( TaskTest task ) 
        {
            dataTest.Tasks.Add( task );
            _startTasks.Add(task);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            int numSelTask = testTab.SelectedIndex;
            if (numSelTask != -1) dataTest.Tasks.RemoveAt(numSelTask);
        }
    }   
}

