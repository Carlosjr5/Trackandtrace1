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

namespace Trackandtrace1
{
    /// <summary>
    /// Interaction logic for location.xaml
    /// </summary>
    public partial class location : Window
    {
        //Creating a list.
        private List<Location> locations = new List<Location>();

        public location()
        {
            InitializeComponent();
        }

        private void Ok_button_Click(object sender, RoutedEventArgs e)
        {
            //Calling the method to set the header
            Location.Header("location_info.csv");
            //Checking for a correct input
            if (!string.IsNullOrEmpty(Location_input.Text))
            {
                //Adding location in the list created, showing it in a message box, and saving it in the CSV file calling the method.
                Location Location1 = new Location();
                Location1.Address = Location_input.Text;
                MessageBox.Show("Location: " + Location1.Address);
                locations.Add(Location1);
                Location.Get_Details(Location_input.Text);
            }
            else
            {
                MessageBox.Show("Please enter a location.");
            }


        }
        
    }
}
