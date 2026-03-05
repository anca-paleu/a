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
    /// Interaction logic for RightWindow.xaml
    /// </summary>
    public partial class RightWindow : Window
    {
        public RightWindow(object dContext)
        {
            InitializeComponent();
            DataContext = dContext;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            (DataContext as PersonList).SelectedPerson = (sender as ListBox).SelectedItem as Person;
        }
    }
}
