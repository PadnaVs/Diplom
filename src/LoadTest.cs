using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diplom_V4.src;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Diplom_V4
{
    public class LoadTest : INotifyPropertyChanged
    {
        private string _name;
        private ObservableCollection<TaskTest> _tasks;
        private User _creater;

        public string Name 
        {
            get 
            {
                return _name;
            }
            set 
            {
                _name = value;
                onPropertyChenged("Name");
            }
        }

        public User Creater
        {
            get
            {
                return _creater;
            }
            set
            {
                _creater = value;
                onPropertyChenged("Creater");
            }
        }

        public ObservableCollection<TaskTest> Tasks
        {
            get
            {
                return _tasks;
            }
            set
            {
                _tasks = value;
                onPropertyChenged("Tasks");
            }
        }

        public LoadTest Copy() {
            return (LoadTest)this.MemberwiseClone(); 
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
