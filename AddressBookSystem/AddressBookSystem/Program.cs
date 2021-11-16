using System;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {                
                Console.WriteLine("\nWelcome to Address Book Program!!!");
                Console.WriteLine("Choose an Option Execute Program\n 1.CreateContact\n 2.AddContact\n 3.Exit\n ");
                int option = Convert.ToInt32(Console.ReadLine());
                Contact contact = new Contact();
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
                        AddressBook addressBook = new AddressBook();
                        Contact addcontact = new Contact();
                        addressBook.Addcontact(contact);
                        addressBook.Display();
                        break;
                    case 3:
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

