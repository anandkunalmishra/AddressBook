using System;
using System.Collections.Generic;
namespace Address_Book
{
	public class CRUD
	{
        private string firstName;
        private string lastName;
        private string address;
        private string city;
        private string state;
        private string zip;
        private string phoneNumber;
        private string email;

        Database data = new Database();

        public void create()
		{
			Console.Clear();
			Console.WriteLine("Hello this is Add window ...");

			//Taking first name of the contact from the user
			Console.WriteLine("Write First Name");
			firstName = Console.ReadLine();

			//Taking last name of contact from the user.
			Console.WriteLine("Write Last Name");
			lastName = Console.ReadLine();

			//Taking address of the contact_person from user. 
			Console.WriteLine("Write address of the person");
			address = Console.ReadLine();

			//Taking city of the Contact person from user.
			Console.WriteLine("Write city of the Contact person");
			city = Console.ReadLine();

			//Taking state name of the person from user.
			Console.WriteLine("Write state of the person");
			state = Console.ReadLine();

			//Taking pincode of the person from user.
			Console.WriteLine("Write pincode of the person");
			zip = Console.ReadLine();

			//Taking phoneNumber of the person from user.
			Console.WriteLine("Write phoneNumber of the person");
			phoneNumber = Console.ReadLine();

			//Taking email of the person from user.
			Console.WriteLine("Write email of the person");
			email = Console.ReadLine();

			Contact newObj = new Contact(firstName, lastName, address, city, state, zip, phoneNumber, email);

			
			data.dict.Add(newObj.FirstName, newObj);

			Console.Clear();
			Console.WriteLine("Contact successfully saved");
		}


		public void retrieve(string firstName)
		{
			Console.Clear();
			if (data.dict.ContainsKey(firstName))
			{
				Console.WriteLine("Contact with First Name Found!\n");
				Contact contact = data.dict[firstName];
				Console.WriteLine($"First Name: {contact.FirstName}");
				Console.WriteLine($"Last Name: {contact.LastName}");
				Console.WriteLine($"Address: {contact.Address}");
				Console.WriteLine($"City: {contact.City}");
				Console.WriteLine($"State: {contact.State}");
				Console.WriteLine($"Pincode: {contact.Pincode}");
				Console.WriteLine($"Phone Number: {contact.PhoneNumber}");
				Console.WriteLine($"Email: {contact.Email}");
			}
			else
			{
				Console.WriteLine($"Contact with firstName {firstName} not Found");
			}
		}

		//public void update(string firstName)
		//{

		//}
	}
}
	

