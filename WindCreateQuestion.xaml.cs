using Diplom_V4.src;
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

namespace Diplom_V4
{
    /// <summary>
    /// Логика взаимодействия для WindCreateQuestion.xaml
    /// </summary>
    public partial class WindCreateQuestion : Window
    {
        private TaskTest _task = new TaskTest();
        private string[] _ans = new string[4];

        public WindCreateQuestion()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (this._task.Name == "" || this._task.Name == null) 
            {
                MessageBox.Show( "Введите свой вопрос!", "Не введён вопрос", MessageBoxButton.OK, MessageBoxImage.Information );
                return;
            }

            for (int i = 0; i < 4; i++) 
            {
                if ( this._ans[i] == "" || this._ans[i] == null ) 
                {
                    string numAnswer = i.ToString();
                    MessageBox.Show("Введите " + numAnswer + " ответ!", "Не введён ответ номер" + numAnswer, MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }
            }

            if (this._task.NumTrueAns == 0 ) {
                MessageBox.Show("Выберите правильный ответ!", "Не выбран правильный ответ", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            this._task.Answers = this._ans;
            if(MainWindow.createTestPage != null) MainWindow.createTestPage.addTask( this._task );
            if(MainWindow.windSeeSelTest != null) MainWindow.windSeeSelTest.addTask( this._task );

            this._task = new TaskTest();
            this._ans = new string[4];

            tbNameTest.Text = "";
            tbAnswer1.Text  = "";
            tbAnswer2.Text  = "";
            tbAnswer3.Text  = "";
            tbAnswer4.Text  = "";

            rb1.IsChecked = false;
            rb2.IsChecked = false;
            rb3.IsChecked = false;
            rb4.IsChecked = false;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        { 
            TextBox textBox = (TextBox)sender;
            this._task.Name = textBox.Text.ToString();
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            this._ans[0] = textBox.Text.ToString();
        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            this._ans[1] = textBox.Text.ToString();
        }

        private void TextBox_TextChanged_3(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            this._ans[2] = textBox.Text.ToString();
        }

        private void TextBox_TextChanged_4(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            this._ans[3] = textBox.Text.ToString();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            this._task.NumTrueAns = 1;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            this._task.NumTrueAns = 2;
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            this._task.NumTrueAns = 3;
        }

        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {
            this._task.NumTrueAns = 4;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            
        }
    }
}
