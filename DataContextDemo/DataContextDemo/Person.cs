using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContextDemo
{
    class Person : INotifyPropertyChanged
    {
        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
                NotifyPropertyChanged(nameof(FirstName));
            }
        }

        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
                NotifyPropertyChanged(nameof(LastName));
            }
        }

        public string FullName
        {
            get { return FirstName + " " + LastName; }
            set
            {
                NotifyPropertyChanged(nameof(FirstName));
                NotifyPropertyChanged(nameof(LastName));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            /*if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));*/
        }
    }
}
