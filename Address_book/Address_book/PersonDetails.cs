using System;
using System.Collections.Generic;

namespace Address_book
{
    internal class PersonDetails
    {
        List<ContactList> contactList = new List<ContactList>();
        //creating a dictonianry to add contact to specific address book
        public static Dictionary<string, List<ContactList>> addressBook = new Dictionary<string, List<ContactList>>();


        //method to take name of address book and store contact in given address book
        public void AddToAddressBook(string addressBookName)
        {

            addressBook.Add(addressBookName, contactList);

        }
        public void AddContact()
        {
            //creating object of ContactDetails class
            ContactList contact = new ContactList();

            Console.Write("Enter First Name::");
            contact.firstName = Console.ReadLine();
            //passing contactlist and contactDetails class object to check particular contactname is present or not
            int checkfirstName = SearchDuplicate(contactList, contact);

            //if checkfirst name is 1 then firstname given by user is not already present in list
            if (checkfirstName == 1)
            {
                Console.Write("Enter Last Name::");
                contact.lastName = Console.ReadLine();

                Console.Write("Enter address::");
                contact.address = Console.ReadLine();

                Console.Write("Enter phone number::");
                contact.phoneNumber = Console.ReadLine();

                Console.Write("Enter email ID::");
                contact.email = Console.ReadLine();

                Console.Write("Enter city Name::");
                contact.city = Console.ReadLine();

                Console.Write("Enter state Name::");
                contact.state = Console.ReadLine();

                Console.Write("Enter zip::");
                contact.zip = Console.ReadLine();

                //adding contact to list
                contactList.Add(contact);
            }

        }

        //this method takes the contactlist and ContactDetails class its object as conatct book
        public static int SearchDuplicate(List<ContactList> contactList, ContactList contactBook)
        {
            foreach (var contactDetails in contactList)                     //loop to iterating through all the elements in contact list 
            {
                var person = contactList.Find(p => p.firstName.Equals(contactBook.firstName));       //using lambda checking given name is alredy present or not using equals method
                                                                                                     //if the name is not null then contact is present already
                if (person != null)
                {
                    Console.WriteLine("Already this contact exist  with current first name::" + person.firstName);
                    return 0;
                }
                else
                {
                    return 1;
                }

            }
            return 1;
        }

        //method to display conatct
        public void DisplayDetails()
        {
            Console.WriteLine("------------Conatct Details Are--------:");

            foreach (var conatct in contactList)
            {

                Console.WriteLine("first name = " + conatct.firstName);
                Console.WriteLine("last name = " + conatct.lastName);
                Console.WriteLine("address = " + conatct.address);
                Console.WriteLine("state = " + conatct.state);
                Console.WriteLine("city = " + conatct.city);
                Console.WriteLine("zip no = " + conatct.zip);
                Console.WriteLine("phone number = " + conatct.phoneNumber);
                Console.WriteLine("email ID = " + conatct.email);
            }
        }

        //method to edit user conatct
        public void EditContact()
        {
            Console.WriteLine("Enter the first name of contact you want to edit.");
            string firstName = Convert.ToString(Console.ReadLine());
            //iterating  contactlist and checking firstname is already available or not for edit contact 
            foreach (ContactList contact in contactList)
            {
                if (contact.firstName == firstName)
                {
                    //to edit the elements
                    Console.Write("Enter First Name::");
                    contact.firstName = Console.ReadLine();

                    Console.Write("Enter Last Name::");
                    contact.lastName = Console.ReadLine();

                    Console.Write("Enter address::");
                    contact.address = Console.ReadLine();

                    Console.Write("Enter phone number::");
                    contact.phoneNumber = Console.ReadLine();

                    Console.Write("Enter email ID::");
                    contact.email = Console.ReadLine();

                    Console.Write("Enter city Name::");
                    contact.city = Console.ReadLine();

                    Console.Write("Enter state Name::");
                    contact.state = Console.ReadLine();

                    Console.Write("Enter zip::");
                    contact.zip = Console.ReadLine();


                }
                else
                {
                    Console.WriteLine("No such name found. Please check and try again!");
                    break;
                }
            }
        }

        //method to delete user conatact using name
        public void DeleteConatct()
        {
            Console.WriteLine("Enter name of contact you want to delete");
            string firstName = Convert.ToString(Console.ReadLine());

            foreach (ContactList contact in contactList)
            {
                //if contact with first name is found then remove th contact
                if (contact.firstName == firstName)
                {
                    contactList.Remove(contact);
                    Console.WriteLine("Contact Deleted successfully.....");
                    break;
                }
                else
                {
                    Console.WriteLine("No such conatact name found.. Plea");
                }
            }
        }
        public void SearchWithCity()
        {
            Console.WriteLine("Please enter the name of the city");
            string city = Console.ReadLine();

            foreach (var Details in contactList)
            {
                //using lambda function checking if given city is presnt or not 
                var person = contactList.Find(p => p.city.Equals(city));
                if (person != null)
                {
                    //if present then prints firstname and city
                    Console.WriteLine("{0}:: resides in the {1} city", Details.firstName, city);
                }
                else
                {

                }
            }

        }
        public void SearchWithState()
        {
            Console.WriteLine("Please enter the name of the state");
            string state = Console.ReadLine();

            foreach (var Details in contactList)
            {
                //using lambda function checking if given state is presnt or not 
                var person = contactList.Find(p => p.city.Equals(state));
                if (person != null)
                {
                    //if present then prints firstname and state
                    Console.WriteLine("{0}:: resides in the {1} state", Details.firstName, state);
                }
                else
                {

                }
            }
        }
    }
}
