using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Diplom_V4.src
{
    public class TaskTest : INotifyPropertyChanged
    {
        private string _name;

        private int _numTrueAns = 0;

        private string[] _answers = new string[4];

        private string _ansStr = "";

        private string SetStrAns() {
            string str = "";
            for (int i = 0; i < _answers.Length; i++)
            {
                str += _answers[i] + "\n";
            }
            return str;
        }

        public string AnswersSrt {
            get
            {
                return _ansStr;
            }
            set 
            {
                _ansStr = value;
                onPropertyChenged("AnswersSrt");
            }
        }

        public string Name {
            get { 
                return _name; 
            }

            set {
                _name = value;
                onPropertyChenged( "Name" );
            }
        }

        public int NumTrueAns
        {
            get { return _numTrueAns; }

            set
            {
                _numTrueAns = value;
                onPropertyChenged("NumTrueAns");
            }
        }

        public string[] Answers 
        {
            get {
                return _answers; 
            }

            set
            {
                _answers = value;
                AnswersSrt = SetStrAns();
                onPropertyChenged("Answers");
            }
        }

       // public static ObservableCollection<TaskTest> GetTask() {
       //     var result = new ObservableCollection<TaskTest>() { 
       //         new TaskTest() { Name="Kakoy?", NumTrueAns = 0, Answers = new string[] { "as","ss","ss","ss" } },
       //         new TaskTest() { Name="Kakoy?", NumTrueAns = 0, Answers = new string[] { "as","ss","ss","ss" } }
       //     };
       //     return result;
       // }


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
