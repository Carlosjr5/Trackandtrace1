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
    /// Interaction logic for visit.xaml
    /// </summary>
    public partial class visit : Window
    {
        //Creating a new list.
        private List<Visits> visits = new List<Visits>();

        public visit()
        {
            InitializeComponent();
        }

        private void Ok_btn_Click(object sender, RoutedEventArgs e)
        {
            //Calling the method to set the header
            Visits.Header_Visits("visits_info.csv");

            //Allowing only numbers .
            bool hour_check = Int32.TryParse(hour_input.Text, out int hour);
            bool minutes_check = Int32.TryParse(min_input.Text, out int minutes);


            //Checking if the input is correct.
            if (!string.IsNullOrEmpty(visit_input.Text) && !string.IsNullOrEmpty(phone_input.Text) && phone_input.Text.Length == 10 && !string.IsNullOrEmpty(datepick.Text) && (hour_check && minutes_check && minutes >= 0 && minutes <= 59 && hour >= 0 && hour <= 24))
            {
                //Looking for a line with the same input.
                Visits v1 = new Visits();                
                string[] linetobefound = Visits.Info_Visits(visit_input.Text, 0);
                string[] findphone = Visits.Info2(phone_input.Text, 1);
                string readytoprint = string.Join(",", linetobefound);
                string foundphone = string.Join(",", findphone);


                //Giving an error by not finding the input information in the CSV file
                if (readytoprint == "Error, Not Found!" || foundphone == "Error, Not Found!")
                {
                    MessageBox.Show("Location not found in the database, please try again!");

                }
                else
                {
                    //Showing in a windows box the information saved it.
                    v1.Place = readytoprint;                   
                    Visits.Add_Visits(foundphone, readytoprint, datepick.Text, hour_input.Text, min_input.Text);
                    MessageBox.Show(foundphone + " visited " + readytoprint + " the " + datepick.Text + " ,at " + hour_input.Text + ":" + min_input.Text);
                }
            }
            else
            {
                //If the input is empty or null give a error message.
                MessageBox.Show("Error!,Please try again.(Input empty or null) or input the hours again incorrectly (hh:mm) ");
                    
            }

            
        }

        
    }
}
