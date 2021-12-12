using System;

namespace AddressBookSystem
{
    class Program
    { 
        static void Main(string[] args)
        {
            Contact contact = new Contact();
            AddressBook addressBook = new AddressBook();
            bool flag = true;
            while (flag)
            {                
                Console.WriteLine("\nWelcome to Address Book Program!!!");
                Console.WriteLine("Choose an Option Execute Program\n 1.CreateContact\n 2.AddContact\n 3.EditContact\n 4.DeleteCOntact\n 5.MultipleAddressBook\n 6.SearchPerson\n 7.Exit\n ");
                int option = Convert.ToInt32(Console.ReadLine());                
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter The Details as Firstname,Lastname,Address,City,State,Zip,PhoneNumber,Email\n");
                        Contact create = new Contact()
                        {
                            FirstName = Console.ReadLine(),
                            LastName = Console.ReadLine(),
                            Address = Console.ReadLine(),
                            City = Console.ReadLine(),
                            State = Console.ReadLine(),
                            Zip = Console.ReadLine(),
                            PhoneNumber = Console.ReadLine(),
                            Email = Console.ReadLine(),
                        };
                        break;
                    case 2:
                        Console.WriteLine("Enter The Details in Order of Firstname,Lastname,Address,City,State,Zip,PhoneNumber,Email... To add contact..\n");
                        addressBook.AddContact(contact);
                        addressBook.Display();
                        break;
                    case 3:                    
                        Console.WriteLine("Enter Contact Name to Edit Details..\n");
                        string name = Console.ReadLine();
                        addressBook.EditContact(name);
                        Console.WriteLine("Edited Successfully\n");
                        addressBook.Display();
                        break;
                    case 4:
                        Console.WriteLine("Enter the Contact Name to deleted : ");
                        string detail = Console.ReadLine();
                        addressBook.DeleteContact(detail);
                        addressBook.Display();
                        break;
                    case 5:
                        Console.WriteLine("Enter The AddressBook Name\n");
                        addressBook.MultipleAddressBook();
                        Console.WriteLine("Enter The Details in Order of Firstname,Lastname,Address,City,State,Zip,PhoneNumber,Email... To add contact..\n");
                        addressBook.AddContact(contact);
                        addressBook.DisplayAddressBook();
                        break;
                    case 6:
                        addressBook.Search_person_city_state();
                        break;
                    case 7:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Enter Correct Option\n");
                        break;

                }
            }
        }
    }
}

