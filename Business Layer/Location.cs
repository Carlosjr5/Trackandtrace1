using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trackandtrace1
{
    class Location
    {
        
        string location;
        

        public string Address
        {
            get { return location; }
            set { location = value; }
        }

        //Adding the Header of the CSV file.
        public static void Header(string filepath)
        {
            string[] head = System.IO.File.ReadAllLines(filepath);
            if (head.Length == 0)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filepath, true))
                {
                    file.WriteLine("Location.");
                }
            }
        }

        //Creating a method to be able to write the information saved it in the CSV file.
        public static void Get_Details(string Address)
        {
            
                using (System.IO.StreamWriter file = new System.IO.StreamWriter("location_info.csv", true))
                {
                file.WriteLine(Address);
                }

        }

       

    } 
    
}
