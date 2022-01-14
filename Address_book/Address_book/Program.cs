using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_book
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program in address book main class in master branch\n");
            PersonDetails user = new PersonDetails();
           
            string yes = "y";

            string y;
            do
            {
                Console.WriteLine("1.AddContact.  2.DisplayContact \t 3.EditContact \t 4.RemoveContact");
                Console.WriteLine("Please enter your choice to perform specific operation::");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\n Enter how many contacts you want to add::");
                        int n = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            user.AddContact();
                            Console.WriteLine("\n ");
                        }

                        break;

                    case 2:
                        user.DisplayContact();
                        break;

                    case 3:
                        user.editContact();
                        break;

                    case 4:
                        user.removeContact();
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
                Console.WriteLine("Do you want to continue ? Press y/n");
                 y = Console.ReadLine();
            } while (yes == y);
            
            Console.ReadLine();
        }
    }
}
