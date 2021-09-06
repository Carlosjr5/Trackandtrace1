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
    /// Interaction logic for contact.xaml
    /// </summary>
    public partial class contact : Window
    {
        public contact()
        {
            InitializeComponent();
        }

        private void Ok_btn_Click(object sender, RoutedEventArgs e)
        {
            //Calling the method to set the header
            Contact.Header("contacts.csv");

            //Allowing only numbers in the text box
            bool hour_check = Int32.TryParse(hour_input.Text, out int hour);
            bool minutes_check = Int32.TryParse(min_input.Text, out int minutes);

            //Checking for an invalid input.
            if (!string.IsNullOrEmpty(u1_name_input.Text) && !string.IsNullOrEmpty(u1_phone_input.Text) && u1_phone_input.Text.Length == 10 && !string.IsNullOrEmpty(u2_name_input.Text) && !string.IsNullOrEmpty(u2_phone_input.Text) && u2_phone_input.Text.Length == 10  && !string.IsNullOrEmpty(date_pick.Text) && (hour_check && minutes_check && minutes >= 0 && minutes <= 59 && hour >= 0 && hour <= 24))
            {
                //Looking for an existing name and phone number in each line
                Contact user1 = new Contact();
                string[] findline = Contact.Info(u1_name_input.Text, 0);
                string lineready = string.Join(",", findline);
                

                Contact user2 = new Contact();
                string[] getline = Contact.Info(u2_name_input.Text, 0);               
                string nameready = string.Join(",", getline);

                if (lineready == "Error, Not Found!" || nameready == "Error, Not Found!")
                {
                    MessageBox.Show("Information not found in the database, please try again!");
                }
                else
                {
                    //Saving the information got it before in the new strings to type in the CSV file
                    user1.User = lineready;                    
                    user2.User = nameready;
                   

                    Contact.Add_Contacts(lineready, nameready, date_pick.Text, hour_input.Text, min_input.Text);
                    //Showing it in the windows box the name, and phone number of both individuals, and date of meeting.
                    MessageBox.Show(lineready + ", was is contact with, " + nameready + ", the date, " + date_pick.Text + " at, " + hour_input.Text + ":" + min_input.Text);
                }

           
            }
            else
            {
                //Giving the error message in case the input is null or empty.
                MessageBox.Show("Error!, Please try again.(Input empty or null) or input the hours again incorrectly(hh:mm).");
            }


        }
    }
}
