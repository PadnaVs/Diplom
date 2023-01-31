using System;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diplom_V4.src;

namespace Diplom_V4
{
    public class TaskModel : INotifyPropertyChanged
    {
        private ObservableCollection<TaskTest> _tasks;
        public ObservableCollection<TaskTest> Tasks {
            get {
                return _tasks;
            }

            set {
                _tasks = value;
                onPropertyChenged("Tasks");
            }
        }

        public TaskModel() {
            //Tasks = TaskTest.GetTask();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void onPropertyChenged( string propertyName ) {
            if (PropertyChanged != null) {
                PropertyChanged( this, new PropertyChangedEventArgs(  propertyName ) );
            }
        }
    }
}
