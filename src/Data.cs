using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Diplom_V4.src;

namespace Diplom_V4
{
    public class Data : INotifyPropertyChanged
    {
        public List<User> users = new List<User>();
        private ObservableCollection<LoadTest> _testsLoaded = new ObservableCollection<LoadTest>();

        public ObservableCollection<LoadTest> TestsLoaded
        {
            get
            {
                return _testsLoaded;
            }
            set
            {
                _testsLoaded = value;
                onPropertyChenged("TestsLoaded");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        void onPropertyChenged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
