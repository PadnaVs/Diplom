using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Collections.ObjectModel;


namespace Diplom_V4
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static NetControl netControl = new NetControl();
        public static Data data = new Data();

        public App()
        {
            data.TestsLoaded = new ObservableCollection<LoadTest>();
        }
    }
       
}
