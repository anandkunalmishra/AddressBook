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

		public void update(string firstName)
		{
			Console.Clear();
			Contact contact = data.dict[firstName];
			while (true)
			{
				Console.Clear();
                Console.WriteLine("Choose the option you want to choose");
                Console.WriteLine("1. First Name");
                Console.WriteLine("2. Last Name");
                Console.WriteLine("3. Address");
                Console.WriteLine("4. City");
                Console.WriteLine("5. State");
                Console.WriteLine("6. Pincode");
                Console.WriteLine("7. Phone Number");
                Console.WriteLine("8. Email");
				Console.WriteLine("9. EXIT");

                int choice;


                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid choice. Please enter a number.");
                    continue;
                }

				switch (choice)
				{
					case 1:
						Console.WriteLine("\nWhat first Name you want to change to");
						contact.FirstName = Console.ReadLine();
						break;
					case 2:
						Console.WriteLine("\nWhat Last name you want to change to");
						contact.LastName = Console.ReadLine();
						break;
					case 3:
						Console.WriteLine("\nWrite Address you want to change to");
						contact.Address = Console.ReadLine();
						break;
					case 4:
						Console.WriteLine("\nWrite the city name you want to change to ");
						contact.City = Console.ReadLine();
						break;
					case 5:
						Console.WriteLine("\nWrite the state name you want to change to");
						contact.State = Console.ReadLine();
						break;
					case 6:
						Console.WriteLine("\nWrite the Phone Number you want to change to");
						contact.PhoneNumber = Console.ReadLine();
						break;
					case 7:
						Console.WriteLine("\nWrite the Email you want to change to");
						contact.Email = Console.ReadLine();
						break;
					case 8:
						Environment.Exit(0);
						break;
					default:
						Console.WriteLine("\nInvalid Choice!: Choose from 1-8");
						break;
				}
            }
		}
	}
}
	

