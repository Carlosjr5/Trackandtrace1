using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trackandtrace1
{
    class User
    {
        string name;
        string phone_number;

        
        public string Name
        {
            get { return name;  }
            set { name = value; }
        }
        public string Phone_number
        {
           get { return phone_number; }
           set { phone_number = value; }
        }



        //Adding the Header of the CSV file.
        public static void Header(string filepath)
        {
            string[] head = System.IO.File.ReadAllLines(filepath);
            if (head.Length == 0)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filepath, true))
                {
                    file.WriteLine("User,Phone Number.");
                }
            }
        }


        //Writing in the CSV.
        public static void Add_User(string Name, string PhoneNumber_TxtBox)
        {

            using (System.IO.StreamWriter file = new System.IO.StreamWriter("user.csv", true))
            {
                file.WriteLine(Name + ","  + PhoneNumber_TxtBox);
            }

        } 
        
    }
}
