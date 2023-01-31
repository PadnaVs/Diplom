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
    /// Логика взаимодействия для WindChangeNameSelTest.xaml
    /// </summary>
    public partial class WindChangeNameSelTest : Window
    {
        private string _startName = ""; 
        public WindChangeNameSelTest()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.windSeeSelTest.saveTestName(tbNameTest.Text);
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow.windSeeSelTest.lbTestName.Text = _startName;
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tbNameTest.Text = MainWindow.windSeeSelTest.lbTestName.Text;
            _startName = String.Copy( tbNameTest.Text );
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            MainWindow.windSeeSelTest.lbTestName.Text = _startName;
            MainWindow.windChangeNameSelTest = null;
            this.Close();
        }

        private void tbNameTest_TextChanged(object sender, TextChangedEventArgs e)
        {
           MainWindow.windSeeSelTest.lbTestName.Text = tbNameTest.Text;
        }
    }
}
