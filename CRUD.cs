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
		}


		//public void retrieve(string firstName)
		//{
		//	Console.WriteLine("What is the firstName of the Person");
		//	Console.WriteLine(data[firstName]);
		//}

		//public void update(string firstName)
		//{

		//}
	}
}
	

