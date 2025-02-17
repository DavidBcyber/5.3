using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _5._3
{
    internal class Program
    {
        // using the data to manage students grades
        static List<string> contact = new List<string>(); // list of grades
        private static IEnumerable<KeyValuePair<string, double>> number;

        static void Main(string[] args)
        {
            int contact = 0; // user input

            //user gets ask what differnt type of method whould they like to use
            Console.WriteLine("Welcome to contact managament application");

            while (true) // loop
            {

                Console.WriteLine("1. vist New Page\n " +
                   "2. Go Back\n " +
                   "3. View Browsing History\n " +
                   "4. Exit\n");

                Console.WriteLine("Enter your choice:");
                contact = Convert.ToInt32(Console.ReadLine());
                // import of the menu

                switch (contact)
                {
                    case 1:
                        // add grade
                        VisitNewPage();
                        break;
                    case 2:
                        // remove grade
                        GoBack();
                        break;
                    case 3:
                        // average
                        ViewBrowsingHistory();
                        break;
                    case 4:
                        //Exit
                        return; // leave site
                    default:
                        //invaild option
                        Console.WriteLine("Invaild Option");
                        break;
                }



            }
        }
        // way to add contact
        static void VisitNewPage()
        {
            Console.WriteLine("Enter webpage URL:");
            string name = Console.ReadLine();

            contact.Add(name); // add contact to the system
            Console.WriteLine(number + "Page visted added successfully");
        }
        static void GoBack()
        {
            Console.WriteLine("Going back to:");
            string VistnewPage = Console.ReadLine();
        }
        static void ViewBrowsingHistory()
        {
            Console.WriteLine("Enter to view your browsing history search");
        }
    }
}
