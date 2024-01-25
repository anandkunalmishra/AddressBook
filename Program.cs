using System;

namespace Locobuzz
{
    class Contact
    {
        public string firstName;
        public string lastName;
        public string address;
        public string city;
        public string state;
        public string zip;
        public string phoneNumber;
        public string email;

        public Contact(string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }
    }

    class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome to the Address book");
        }
    }

}
