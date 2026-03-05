using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataContextDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void B1_Click(object sender, RoutedEventArgs e)
        {
            //LeftWindow lWind = new LeftWindow(this.DataContext);
            LeftWindow lWind = new(this.DataContext);
            lWind.ShowDialog();
        }
        private void B2_Click(object sender, RoutedEventArgs e)
        {
            //RightWindow rWind = new RightWindow(this.DataContext);
            RightWindow rWind = new(this.DataContext);
            rWind.ShowDialog();
        }
    }
}