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

namespace DataContextDemo
{
    /// <summary>
    /// Interaction logic for LeftWindow.xaml
    /// </summary>
    public partial class LeftWindow : Window
    {
        public LeftWindow(object dContext)
        {
            InitializeComponent();
            DataContext = dContext;
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            //Person p = new Person() { FirstName = firstTxt.Text, LastName = lastTxt.Text };
            Person p = new() { FirstName = firstTxt.Text, LastName = lastTxt.Text };
            (DataContext as PersonList).Persons.Add(p);
            MessageBox.Show("Person added!!");
        }
    }
}
