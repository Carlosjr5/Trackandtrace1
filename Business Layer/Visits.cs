using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trackandtrace1
{
    class Visits : Contact
    {
        string place;
        //Saving the input for later on typed in the CSV file
        public string Place
        {
            get { return place; }
            set { place = value; }
        }

        //Adding the Header of the CSV file.
        public static void Header_Visits(string filepath)
        {
            string[] head = System.IO.File.ReadAllLines(filepath);
            if (head.Length == 0)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filepath, true))
                {
                    file.WriteLine("User, Phone Number, Location, Date, Time.");
                }
            }
        }

        //Checking for the existing location.
        public static string[] Info_Visits(string find, int position)
        {

            string[] empty = { "Error, Not Found!" };

            string[] Read = System.IO.File.ReadAllLines("location_info.csv");

            
            for (int i = 0; i < Read.Length; i++)
            {               
                string[] Set = Read[i].Split(',');
                 
                if (Match(find, Set, position))
                {
                    Console.WriteLine("Already exist");
                    return Set;
                }
                
            }
            

            return empty;

        }

        //Checking for an existing user.
        public static string[] Info2(string find, int position)
        {
            string[] empty = { "Error, Not Found!" };

            string[] Read = System.IO.File.ReadAllLines("user.csv");

            for (int i = 0; i < Read.Length; i++)
            {
                string[] Set = Read[i].Split(',');

                if (Match(find, Set, position))
                {
                    Console.WriteLine("Already exist");
                    return Set;
                }
            }
            return empty;
        }

        //Returning the values input to the CSV File.
        public static bool Match_Visits(string find, string[] check, int position)
        {
            if (check[position].Equals(find))
            {
                return true;
            }
            return false;
        }

      
        //Adding the information in the CSV file.
        public static void Add_Visits(string foundphone, string readytoprint,string Date, string hour_input, string min_input)
        {
            
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("visits_info.csv", true))
            {              
                file.WriteLine(foundphone + "," + readytoprint + "," + Date + ", at " + hour_input + ":" + min_input);
            }
        }

        
    }
}
