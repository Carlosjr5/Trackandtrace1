
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trackandtrace1
{
    class Contact
    {
        string user;
       
        

       
        public string User
        {
            get { return user; }
            set { user = value; }
        }

        //Adding the Header of the CSV file.
        public static void Header(string filepath)
        {
            string[] head = System.IO.File.ReadAllLines(filepath);
            if (head.Length == 0)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filepath, true))
                {
                    file.WriteLine("User1, Phone Number, User2, Phone Number, Date, Time.");
                }
            }
        }

        //Looking each lines for the match with the input entered by the user.
        public static string[] Info(string find, int position)
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

   
        //Returning the values input to the CSV 
        public static bool Match(string find, string[] check, int position)
        {
            if (check[position].Equals(find))
            {
                return true;
            }
            return false;
        }

        //To write in the CSV file.
        public static void Add_Contacts(string lineready, string nameready, string Date, string hour_input, string min_input)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("contacts.csv", true))
            {
                file.WriteLine(lineready + "," + nameready + "," + Date + "," + hour_input + ":" + min_input);
            }
        }


    }
}
