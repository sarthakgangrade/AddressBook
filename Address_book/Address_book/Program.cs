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
            Console.WriteLine("Welcome to address book program");
            ContactList contact = new ContactList();
            Console.WriteLine("Enter the number of Address Books you want to add:");
            int noOfAddressBooks = Convert.ToInt32(Console.ReadLine());
            int noOfBooks = 0;

            while (noOfBooks != noOfAddressBooks)
            {
                PersonDetails user = new PersonDetails();
                string keyPress = "y";
                Console.WriteLine("Enter the name of address book::");
                string addressBookName = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Enter your Choice to perform specific operation on address book.");
                Console.WriteLine();
                while (keyPress != "n")
                {
                    Console.WriteLine("1:AddContact 2:DisplayContact 3:EditContact 4:DeleteContact 5:SearchContactByCity 6:SearchContactByState");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {

                        case 1:
                            Console.WriteLine("Enter how many contacts you want to add to address book::");
                            int number = Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i < number; i++)
                            {
                                user.AddContact();
                            }
                            break;

                        case 2:
                            user.DisplayDetails();
                            break;

                        case 3:
                            user.EditContact();
                            break;

                        case 4:
                            user.DeleteConatct();
                            break;
                        case 5:
                            user.SearchWithCity();
                            break;
                        case 6:
                            user.SearchWithState();
                            break;
                    }
                    Console.WriteLine("Do you want to continue ?... Press y/n");
                    keyPress = Console.ReadLine();

                }
                user.AddToAddressBook(addressBookName);
                noOfBooks++;

            }


        }
    }
}

