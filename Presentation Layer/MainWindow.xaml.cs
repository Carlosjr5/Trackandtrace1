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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Trackandtrace1
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


        private void Add_individual_Click(object sender, RoutedEventArgs e)
        {
            individual_input newWin = new individual_input();
            newWin.Show();
           
        }

        private void Location_button_Click(object sender, RoutedEventArgs e)
        {
            location newWin = new location();
            newWin.Show();
        }

        private void Visit_btn_Click(object sender, RoutedEventArgs e)
        {
            visit newWin = new visit();
            newWin.Show();
        }

        private void Contact_btn_Click(object sender, RoutedEventArgs e)
        {
            contact newWin = new contact();
            newWin.Show();
        }
    }
}

