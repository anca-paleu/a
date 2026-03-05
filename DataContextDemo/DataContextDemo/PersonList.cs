using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContextDemo
{
    class PersonList
    {
        public ObservableCollection<Person> Persons { get; set; }
        public Person SelectedPerson { get; set; }

        /*public PersonList()
        {
            Persons = new ObservableCollection<Person>();
        }*/

        public PersonList() => Persons = [];
    }
}
