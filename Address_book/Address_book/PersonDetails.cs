using System;
using System.Collections.Generic;

namespace Address_book
{
    internal class PersonDetails
    {
        private LinkedList<ContactList> contactDetails = new LinkedList<ContactList>();

        //instance variables
        public string firstName;
        public string lastName;
        public string address;
        public string city;
        public string state;
        public int zip;
        public long phoneNumber;
        public string email;


        //CreateContact() method to create the contact of user with all details
        public void AddContact()
        {
            Console.Write("Enter the First Name::");
            firstName = Console.ReadLine();
            Console.Write("Enter the Last Name::");
            lastName = Console.ReadLine();
            Console.Write("Enter the Adresss::");
            address = Console.ReadLine();
            Console.Write("Enter the City::");
            city = Console.ReadLine();
            Console.Write("Enter the State::");
            state = Console.ReadLine();
            Console.Write("Enter the Zip Code::");
            zip = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Phone Number::");
            phoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter the Email::");
            email = Console.ReadLine();

            //creating object of contactList class
            ContactList contactList = new ContactList(firstName, lastName, address, city, state, zip, phoneNumber, email);
            //adding contact details to contact list
            this.contactDetails.AddLast(contactList);
        }

        //method to display user contact details
        public void DisplayContact()
        {
            Console.WriteLine("\n \n --------- Details of User --------- \n\n");
            //checking list is empty or not 
            if (contactDetails.Count == 0)
            {
                Console.WriteLine("AddressBook is Empty");

            }
            else
            {
                //printing the contact details stored in array list
                foreach (ContactList contactList in this.contactDetails)
                {
                    Console.WriteLine($"FirstName= {contactList.firstName} LastName= {contactList.lastName} Address= {contactList.address} City={contactList.city} state= {contactList.state} ZipCode= {contactList.zip} Phone= {contactList.phoneNumber} Email= {contactList.email}");

                }
            }

        }

        //method to edit the contact
        public void editContact()
        {
            //checking list is empty or not
            if (contactDetails.Count == 0)
            {
                Console.WriteLine("AddressBook is Empty");

            }
            else
            {
                Console.WriteLine("enter the name which want to edit contact:");
                string name = Console.ReadLine();

                foreach (ContactList contactList in this.contactDetails)
                {
                    //checking if name is present in contact list or not 
                    if (contactList.firstName == name)
                    {
                        Console.WriteLine($"FirstName= {contactList.firstName} LastName= {contactList.lastName} Address= {contactList.address} City={contactList.city} state= {contactList.state} ZipCode= {contactList.zip} Phone= {contactList.phoneNumber} Email= {contactList.email}");
                        Console.WriteLine("\n The {0} is present in contact list and you can edit the details...", contactList.firstName);
                        Console.WriteLine("enter the details");

                        Console.WriteLine("Enter the First Name");
                        contactList.firstName = Console.ReadLine();

                        Console.WriteLine("Enter the Last Name");
                        contactList.lastName = Console.ReadLine();

                        Console.WriteLine("Enter the Adresss");
                        contactList.address = Console.ReadLine();

                        Console.WriteLine("Enter the City");
                        contactList.city = Console.ReadLine();

                        Console.WriteLine("Enter the State");
                        contactList.state = Console.ReadLine();

                        Console.WriteLine("Enter the Zip Code");
                        contactList.zip = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter the Phone Number");
                        contactList.phoneNumber = Convert.ToInt64(Console.ReadLine());

                        Console.WriteLine("Enter the Email");
                        contactList.email = Console.ReadLine();

                        Console.WriteLine("updated contact details List");
                        //printing the changed contact details
                        Console.WriteLine($"FirstName= {contactList.firstName} LastName= {contactList.lastName} Address= {contactList.address} City={contactList.city} state= {contactList.state} ZipCode= {contactList.zip} Phone Number= {contactList.phoneNumber} Email= {contactList.email}");

                    }
                    else
                    {

                        Console.WriteLine("The conatct name {0} is not present in ContactList", contactList.firstName);

                    }

                }
            }
        }

        //method for removing the contact details
        public void removeContact()
        {
            //condition to check list is empty or not
            if (contactDetails.Count == 0)
            {
                Console.WriteLine("AddressBook is Empty");

            }
            else
            {
                Console.WriteLine("enter the name you want to remove");
                string name = Console.ReadLine();

                foreach (ContactList contactList in this.contactDetails)
                {
                    //checking entered name is present in list or not 
                    if (contactList.firstName == name)
                    {
                        //and if present then remove contact
                        contactDetails.Remove(contactList);
                        break;

                    }
                    else
                    {
                        //else print the contact is not present in list
                        Console.WriteLine("the {0} is not present", contactList.firstName);

                    }
                }

            }
        }
    }
}