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
    /// Логика взаимодействия для RegisterPage.xaml
    /// </summary>
    public partial class RegisterPage : Page
    {
        private string _userName;
        private string _lastName;
        private string _numGroup;
        private string _email;
        private string _position;
        private string _password;
        public RegisterPage()
        {
            InitializeComponent();
            this.ShowsNavigationUI = false;
        }
        private void register_Click(object sender, RoutedEventArgs e)
        {
            if (this._userName == "" || this._userName == null)
            {
                MessageBox.Show("Ввеите имя!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            else if (this._lastName == "" || this._lastName == null)
            {
                MessageBox.Show("Ввеите фамилию!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information); 
                return;
            }
            else if (this._password == "" || this._password == null)
            {
                MessageBox.Show("Ввеите пароль!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            else if (this._email == "" || this._email == null)
            {
                MessageBox.Show("Ввеите email!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            else if (this._position == "" || this._position == null)
            {
                MessageBox.Show("Выберите вашу категорию!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            else if (this._position == "Студент" || this._position == null)
            {
                if (this._numGroup == "" || this._numGroup == null)
                {
                    MessageBox.Show("Введите номер группы!","Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }
            }

            void checkRegister()
            {
                bool res = true;
                foreach (User user in App.data.users)
                {
                    if (user.name == this._userName && user.lasnName == this._lastName && user.numGroup == this._numGroup)
                    {
                        if (user.email == this._email)
                        {
                            MessageBox.Show("Такая почта уже использованна!\n Введите другие данные.", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                        else
                        {
                            MessageBox.Show("Такой пользователь уже существует!\n Введите другие данные.", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                        };
                        res = false;
                        break;
                    };
                }
                if (res)
                {
                    string str = "INSERT INTO Users( Name, LastName, Email, UserType, Password, NumGroup ) VALUES( '" + this._userName + "','" + this._lastName + "', '" + this._email + "', '" + this._position + "','" + this._password + "','" + this._numGroup + "')";
                    App.netControl.inserToBd(str);

                    MessageBox.Show("Регистрация успешно завершена!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                    MainWindow.frame.Navigate( MainWindow.mainPage );
                }
            }

            App.netControl.fillCollUsers(this._position);
            App.netControl.useresAreFull += checkRegister;
        }

        private void Name_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            this._userName = textBox.Text;
        }

        private void LastName_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            this._lastName = textBox.Text;
        }

        private void NumGr_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            this._numGroup = textBox.Text;
        }

        private void Email_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            this._email = textBox.Text;
        }

        private void Password_PasswordChanged(object sender, RoutedEventArgs e)
        {
            PasswordBox textBox = (PasswordBox)sender;
            this._password = textBox.Password;
        }

        private void cmKtSotr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
            ComboBox comboBox = (ComboBox)sender;
            if (comboBox.SelectedItem == null) return;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
            TextBlock textBlock = (TextBlock)selectedItem.Content;
            this._position = textBlock.Text;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Name.Text              = "";
            LastName.Text          = "";
            Email.Text             = "";
            Password.Password      = "";
            NumGr.Text             = "";
            cmKtSotr.SelectedIndex = -1;
        }

        private void return_Click(object sender, RoutedEventArgs e)
        {
            cmKtSotr.SelectedItem = null;
            MainWindow.frame.Navigate( MainWindow.mainPage );
        }
    }
}
