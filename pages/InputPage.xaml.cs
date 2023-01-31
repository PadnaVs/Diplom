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
    /// Логика взаимодействия для InputPage.xaml
    /// </summary>
    public partial class InputPage : Page
    {
        public InputPage()
        {
            InitializeComponent();
        }

        private void btInput_Click(object sender, RoutedEventArgs e)
        {
            int coutTouch = 0;
            void checkRegister()
            {
                coutTouch++;
                if (coutTouch > 1) return;
                if (MainWindow.inputedUser) return;
                if (App.netControl.currentUser.name == null)
                {
                    MessageBox.Show("Такой " + MainWindow.currentUser + " не найден!\n Проверьте введённые данные!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }
                else
                {
                    if (App.netControl.currentUser.password != this.pbInput.Password)
                    {
                        MessageBox.Show("Пароль не верен!\n Проверьте введённые данные!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                        return;
                    }

                    if (MainWindow.currentUser == "Преподаватель")
                    {
                        MainWindow.frame.Navigate(MainWindow.startPageTeacher);
                    }
                    else if(MainWindow.currentUser == "Студент")
                    {
                        MainWindow.frame.Navigate(MainWindow.startPageStudent);
                    }
                    MainWindow.inputedUser = true;
                }
            }

            App.netControl.getIncomingUser(MainWindow.currentUser, inputEmail.Text);
            
            App.netControl.useresAreFull += checkRegister;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            inputEmail.Text  = "";
            pbInput.Password = "";
            
            lbFU.Content = MainWindow.currentUser;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.frame.Navigate(MainWindow.mainPage);
        }
    }
}

