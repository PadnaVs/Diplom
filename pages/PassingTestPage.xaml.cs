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
using Diplom_V4.src;

namespace Diplom_V4.pages
{
    /// <summary>
    /// Логика взаимодействия для PassingTestPage.xaml
    /// </summary>
    public partial class PassingTestPage : Page
    {
        public int    numSelTest         = -1;
        public double resultPassingTest = -1;

        private LoadTest _loadTest;

        //логика теста//
        private int _numCurrentTask =  0;
        private int _selTrueAnswer  = -1;
        private int _countAnswerU   =  0;

        private TaskTest _curTasks;
        private int[] _answersUser;
        public PassingTestPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            _loadTest = App.data.TestsLoaded.ElementAt(this.numSelTest);
            _answersUser = new int[_loadTest.Tasks.Count];
            _numCurrentTask = 0;
            _selTrueAnswer = -1;
            _countAnswerU = 0;
            numSelTest = -1;
            resultPassingTest = -1;

            showTask(_numCurrentTask);
        }

        private void showTask(int Num) 
        {
            _curTasks = getTask(Num);

            lbNameTest.Text = _curTasks.Name;

            lbAnswer0.Content = _curTasks.Answers[0];
            lbAnswer1.Content = _curTasks.Answers[1];
            lbAnswer2.Content = _curTasks.Answers[2];
            lbAnswer3.Content = _curTasks.Answers[3];

            _selTrueAnswer = -1;

            rb0.IsChecked = false;
            rb1.IsChecked = false;
            rb2.IsChecked = false;
            rb3.IsChecked = false;
        }

        private TaskTest getTask(int num) 
        {
            TaskTest res = _loadTest.Tasks.ElementAt(num);
            return res;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            _selTrueAnswer = 1;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            _selTrueAnswer = 2;
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            _selTrueAnswer = 3;
        }

        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {
            _selTrueAnswer = 4;
        }

        private void butShowTaskL_Click(object sender, RoutedEventArgs e)
        {
            if( _numCurrentTask - 1 > 0 ) 
            {
                _numCurrentTask--;
                showTask( _numCurrentTask );
            }
        }

        private void butShowTaskR_Click(object sender, RoutedEventArgs e)
        {
            if ( _numCurrentTask+1 < _loadTest.Tasks.Count )
            {
                _numCurrentTask++;
                showTask(_numCurrentTask);
            }
        }

        private void butToAnswer_Click(object sender, RoutedEventArgs e)
        {
            if (_selTrueAnswer == -1)
            {
                MessageBox.Show("Выберите правильный на ваш взгляд ответ!", "Не выбран ответ!", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            _answersUser[_numCurrentTask] = _selTrueAnswer;
            _countAnswerU++;

            if ( _countAnswerU == _answersUser.Length ) 
            {
                int countTrueAns = 0;
                for (int i = 0; i < _answersUser.Length; i++)
                { 
                    if (_answersUser[i] == _loadTest.Tasks.ElementAt(i).NumTrueAns) countTrueAns++;
                }

                resultPassingTest = Math.Round( (System.Convert.ToDouble(countTrueAns) / System.Convert.ToDouble(_answersUser.Length)) * 5 );

                MainWindow.frame.Navigate( MainWindow.completedTestPage );
                return;
            }

            for (int i = 0; i < _answersUser.Length; i++)
            {
                if (_answersUser[i] == 0) 
                {
                    _numCurrentTask = i;
                    break;
                }
            }
            showTask( _numCurrentTask );
        }

        public LoadTest getSelTest() 
        {
            return _loadTest;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.frame.Navigate( MainWindow.startPageStudent );
        }
    }
}
