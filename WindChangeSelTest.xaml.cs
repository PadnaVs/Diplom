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

namespace Diplom_V4
{
    /// <summary>
    /// Логика взаимодействия для WindChangeSelTest.xaml
    /// </summary>
    public partial class WindChangeSelTest : Window
    {
        private string[] _changedTasks = new string[4];
        private TaskTest _changedTask;

        public WindChangeSelTest()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            checkChanged();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _changedTask = MainWindow.windSeeSelTest.selTask;
            this.Close();
        }

        public void setChangeTask(TaskTest selTask ) 
        {
            _changedTask = new TaskTest() { Name = selTask.Name, Answers = selTask.Answers, NumTrueAns = selTask.NumTrueAns };
        }

        public void checkChanged() 
        {
            bool checkName     = _changedTask.Name       == MainWindow.windSeeSelTest.selTask.Name;
            bool chechTrueAnsw = _changedTask.NumTrueAns == MainWindow.windSeeSelTest.selTask.NumTrueAns;
            bool checkAnw = true;

            for (int i = 0; i < _changedTask.Answers.Length; i++) 
            {
                if(_changedTask.Answers[i] != MainWindow.windSeeSelTest.selTask.Answers[i])
                {
                    checkAnw = false;
                    break;
                }
            }

            if (!checkName || !chechTrueAnsw || !checkAnw)
            {
                MainWindow.windSeeSelTest.selTask.Name = _changedTask.Name;
                MainWindow.windSeeSelTest.selTask.NumTrueAns = _changedTask.NumTrueAns;
                
                MainWindow.windSeeSelTest.selTask.Answers = _changedTask.Answers;
            } 
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            setChangeTask(MainWindow.windSeeSelTest.selTask);
        }

        public void fillFiedls( TaskTest selTask) 
        {

            _changedTasks[0] = selTask.Answers[0];
            _changedTasks[1] = selTask.Answers[1];
            _changedTasks[2] = selTask.Answers[2];
            _changedTasks[3] = selTask.Answers[3];

            tbNameTest.Text = selTask.Name;
            tbAnswer1.Text = selTask.Answers[0];
            tbAnswer2.Text = selTask.Answers[1];
            tbAnswer3.Text = selTask.Answers[2];
            tbAnswer4.Text = selTask.Answers[3];

            switch (selTask.NumTrueAns)
            {
                case 1:
                    rb1.IsChecked = true;
                    break;

                case 2:
                    rb2.IsChecked = true;
                    break;

                case 3:
                    rb3.IsChecked = true;
                    break;

                case 4:
                    rb4.IsChecked = true;
                    break;
            }
        }

        private void tbNameTest_TextChanged(object sender, TextChangedEventArgs e)
        {
            MainWindow.windSeeSelTest.selTask.Name = tbNameTest.Text;       
        }

        private void tbAnswer1_TextChanged(object sender, TextChangedEventArgs e)
        {
            _changedTasks[0] = tbAnswer1.Text;
            MainWindow.windSeeSelTest.selTask.Answers = _changedTasks;
        }

        private void tbAnswer2_TextChanged(object sender, TextChangedEventArgs e)
        {
            _changedTasks[1] = tbAnswer2.Text;
            MainWindow.windSeeSelTest.selTask.Answers = _changedTasks;
        }

        private void tbAnswer3_TextChanged(object sender, TextChangedEventArgs e)
        {
            _changedTasks[2] = tbAnswer3.Text;
            MainWindow.windSeeSelTest.selTask.Answers = _changedTasks;
        }

        private void tbAnswer4_TextChanged(object sender, TextChangedEventArgs e)
        {
            _changedTasks[3] = tbAnswer4.Text;
            MainWindow.windSeeSelTest.selTask.Answers = _changedTasks;
        }

        private void rb1_Checked(object sender, RoutedEventArgs e)
        {
            MainWindow.windSeeSelTest.selTask.NumTrueAns = 1;
        }

        private void rb2_Checked(object sender, RoutedEventArgs e)
        {
            MainWindow.windSeeSelTest.selTask.NumTrueAns = 2;
        }

        private void rb3_Checked(object sender, RoutedEventArgs e)
        {
            MainWindow.windSeeSelTest.selTask.NumTrueAns = 3;
        }

        private void rb4_Checked(object sender, RoutedEventArgs e)
        {
            MainWindow.windSeeSelTest.selTask.NumTrueAns = 4;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            checkChanged();
            MainWindow.windChangeSelTest = null;
        }
    }
}
