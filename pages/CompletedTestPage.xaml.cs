using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Configuration;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Net;
using System.Net.Mail;


namespace Diplom_V4.pages
{
    /// <summary>
    /// Логика взаимодействия для CompletedTestPage.xaml
    /// </summary>
    public partial class CompletedTestPage : Page
    {
        private static string _emailFromSt = ConfigurationManager.ConnectionStrings["email"].ConnectionString;
        private static string _emailPasswordFromSt = ConfigurationManager.ConnectionStrings["passwordEmail"].ConnectionString;
        private MailAddress _eMailFrom = new MailAddress(_emailFromSt, "Программа тестирования студентов");
        private MailAddress _eMailTo;
        private MailMessage _msg;
        private SmtpClient _smtp;
        
        public CompletedTestPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            if (MainWindow.passingTestPage.resultPassingTest == 2.0 || MainWindow.passingTestPage.resultPassingTest == 1.0)
            {
                lbResult.Content = "Не удовлетворительно";
            }
            else if (MainWindow.passingTestPage.resultPassingTest == 3.0)
            {
                lbResult.Content = "Удовлетворительно";
            }
            else if (MainWindow.passingTestPage.resultPassingTest == 4.0)
            {
                lbResult.Content = "Хорошо";
            }
            else if (MainWindow.passingTestPage.resultPassingTest == 5.0)
            {
                lbResult.Content = "Отлично";
            }
            _smtp = new SmtpClient("smtp.yandex.ru", 587) { 
                Credentials = new NetworkCredential(_emailFromSt, _emailPasswordFromSt) 
            };
            _eMailTo = new MailAddress(MainWindow.passingTestPage.getSelTest().Creater.email);
            setMessageToEMail();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.frame.Navigate( MainWindow.startPageStudent );
        }

        private void setMessageToEMail() 
        {
            try
            {    
                _msg = new MailMessage(_eMailFrom, _eMailTo);
                _msg.Subject = "Ваш тест пройден студентом!";

                string nameStudent = App.netControl.currentUser.name + " " + App.netControl.currentUser.lasnName;
                _msg.Body = "<p>" + "Тест пройден студентом " + nameStudent + " группы:" + App.netControl.currentUser.numGroup + "<br>" + "С результатом: " + lbResult.Content + "<p>";
                _msg.IsBodyHtml = true;
                _smtp.EnableSsl = true;
                _smtp.Send(_msg);
            }
            catch( Exception ex ) 
            {
               MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        } 
    }
}
