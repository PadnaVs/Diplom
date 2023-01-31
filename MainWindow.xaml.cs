using Diplom_V4.pages;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Diplom_V4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Frame frame;
        public static MainPage          mainPage                  = new MainPage();
        public static RegisterPage      registerPage              = new RegisterPage();
        public static InputPage         inputPage                 = new InputPage();
        public static StartPageTeacher  startPageTeacher          = new StartPageTeacher();
        public static StartPageStudent  startPageStudent          = new StartPageStudent();
        public static CreateTestPage    createTestPage            = new CreateTestPage();
        public static PassingTestPage   passingTestPage           = new PassingTestPage();
        public static CompletedTestPage completedTestPage         = new CompletedTestPage();

        public static WindCreateQuestion    windCreateQuestion;
        public static WindSeeTests          windSeeTests;
        public static WindSeeSelTest        windSeeSelTest;
        public static WindChangeSelTest     windChangeSelTest;
        public static WindChangeNameSelTest windChangeNameSelTest;

        public static string currentUser  = null;
        public static bool   inputedUser = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            frame = this.Frame;
            frame.Navigate(mainPage);
            App.netControl.conectionToDb();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            App.netControl.connetionClose();
            if (windChangeNameSelTest != null) windChangeNameSelTest.Close();
            if (windChangeSelTest != null)     windChangeSelTest.Close();
            if (windSeeSelTest != null)        windSeeSelTest.Close();
            if (windSeeTests != null)          windSeeTests.Close();
            if (windCreateQuestion != null)    windCreateQuestion.Close();
        }
    }
}
