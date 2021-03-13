using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

namespace _2Term_OOP_Lab4
{
    class MainWindowVM : INotifyPropertyChanged
    {
        private string outText;
        internal string OutText
        {
            get { return outText; }
            set { outText = value; OnPropertyChanged("OutText"); }

        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
