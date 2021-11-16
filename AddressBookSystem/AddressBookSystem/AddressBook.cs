using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    class AddressBook
    {
        List<Contact> addresslist = new List<Contact>();
        public void Addcontact(Contact contact)
        {
            addresslist.Add(contact);
            contact.FirstName = Console.ReadLine();
            contact.LastName = Console.ReadLine();
            contact.Address = Console.ReadLine();
            contact.City = Console.ReadLine();
            contact.State = Console.ReadLine();
            contact.Zip = Console.ReadLine();
            contact.PhoneNumber = Console.ReadLine();
            contact.Email = Console.ReadLine();
        }
        public void Display()
        {
            foreach(var contact in addresslist)
            {
                Console.WriteLine("Entered Contact Details are..\n");
                Console.Write("Firstname: " + contact.FirstName + "\n" + "Lastname: " + contact.LastName + "\n" + "Address: " + contact.Address + "\n" + "City: " + contact.City + "\n" + "State: " + contact.State + "\n" + "Zip: " + contact.Zip + "\n" + "Phone No.: " + contact.PhoneNumber + "\n" + "Email: " + contact.Email + "\n");
            }
        }

    }
}
