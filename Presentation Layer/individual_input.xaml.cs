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
    /// Interaction logic for individual_input.xaml
    /// </summary>
    public partial class individual_input : Window
    {
        private List<User> users = new List<User>();


        public individual_input()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            
            User.Header("user.csv");
            bool phone_check = Int32.TryParse(PhoneNumber_TxtBox.Text, out int Phone_number);
            //check lenght of phone number.
            if ((PhoneNumber_TxtBox.Text.Length == 10) && !string.IsNullOrEmpty(FullName_TxtBox.Text))
            {
                User User1 = new User();
                User1.Name = FullName_TxtBox.Text;
                User1.Phone_number = PhoneNumber_TxtBox.Text;
                MessageBox.Show("Name: " + User1.Name + ", Phone Number: " + User1.Phone_number);
                users.Add(User1);
                User.Add_User(FullName_TxtBox.Text, PhoneNumber_TxtBox.Text);
            } else
            {

                MessageBox.Show("Please enter a correct phone number and name.");
            }
            
            

        }
    }
}
