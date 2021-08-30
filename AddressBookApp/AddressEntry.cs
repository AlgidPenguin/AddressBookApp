using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookApp
{
    public class AddressEntry
    {
        public AddressEntry()
        {

        }

        public AddressEntry(string firstName, string lastName, string address, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            PhoneNumber = phoneNumber;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
