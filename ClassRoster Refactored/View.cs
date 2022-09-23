using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoster_Refactored
{
    internal class View
    {
        public void printMenu()
        {
            Console.WriteLine("Class Roster in C#");
            Console.WriteLine("------------------");
        }

        public string Menu()
        {
            Console.WriteLine("\ts - Add Student");
            Console.WriteLine("\tp - Add Professor");
            Console.WriteLine("\tr - Print Roster");
            Console.WriteLine("\tx - Sort Roster");
            Console.WriteLine("\te - End Application");

            var selection = Console.ReadLine();
            return Convert.ToString(selection);
        }

        public string getFirstName()
        {
            Console.WriteLine("What is the first name of this person?");
            string result = Console.ReadLine();
            if (!string.IsNullOrEmpty(result))
            {
                return result;
            } else
            {
                return getFirstName();
            }
            
        }

        public string getLastName()
        {
            Console.WriteLine("What is the last name of this person");
            string result = Console.ReadLine();
            if(!string.IsNullOrEmpty(result))
            {
                return result;
            } else
            {
                return getLastName();
            }
        }

        public string getEmail()
        {
            Console.WriteLine("What is the email address for this professor?");
            string result = Console.ReadLine();
            if(!string.IsNullOrEmpty(result))
            {
                return result;
            } else
            {
                return getEmail();
            }
         
        }

        public string getRank()
        {
            Console.WriteLine("What is the class rank of this student");
            string result = Console.ReadLine();
            if(!string.IsNullOrEmpty(result))
            {
                return result;
            } else
            {
                return getRank();
            }
        }

        public void printStudent(String firstName, String lastName, string Rank)
        {
            Console.WriteLine(firstName + " " + lastName + " " + Rank);
        }

        public void printProfessor(String firstName, string lastName, string Email)
        {
            Console.WriteLine(firstName + " " + lastName + " " + Email);
        }


    }
}
