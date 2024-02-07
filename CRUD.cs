using System.Diagnostics.Metrics;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Address_Book
{
	public class CRUD
	{
		private string firstName="";
		private string lastName="";
		private string address="";
		private string city="";
		private string state="";
		private string zip="";
		private string phoneNumber="";
		private string email="";

		Database data = new Database();

		Validator validator = new Validator();

		public void create()
		{
			Console.Clear();
			Console.WriteLine("Hello this is Add window ...");

			//Taking first name of the contact from the user
			while (!validator.isValidName(firstName))
			{
				Console.WriteLine("Write First Name");
				firstName = Console.ReadLine();
                if (data.dict.ContainsKey(firstName))
                {
                    Console.WriteLine("User Already exist please enter Again");
					firstName = "";
					Console.WriteLine("Press Enter to do again");
					Console.ReadLine();
					Console.Clear();
					create();
                    return;
                }
                if (!validator.isValidName(firstName))
				{
					Console.WriteLine("\nEnter name only where first letter should be in Capital and Enter only Letters");
				}
				//checking for the unique name if the name already exists or what
				if (data.dict.ContainsKey(firstName))
				{
					Console.WriteLine("User Already exist please enter Again");
					break;
				}
			}
			//Taking last name of contact from the user.
			while (!validator.isValidName(lastName))
			{
				Console.WriteLine("Write Last Name");
				lastName = Console.ReadLine();
                if (!validator.isValidName(lastName))
                {
                    Console.WriteLine("\nEnter name only where first letter should be in Capital");
                }
            }

			//Taking address of the contact_person from user. 
			Console.WriteLine("Write address of the person");
			address = Console.ReadLine();

			//Taking city of the Contact person from user.
			while (!validator.isValidName(city))
			{
				Console.WriteLine("Write city of the Contact person");
				city = Console.ReadLine();
                if (!validator.isValidName(city))
                {
                    Console.WriteLine("\nEnter name only where first letter should be in Capital");
                }
            }

			//Taking state name of the person from user.
			while (!validator.isValidName(state))
			{
				Console.WriteLine("Write state of the person");
				state = Console.ReadLine();
                if (!validator.isValidName(state))
                {
                    Console.WriteLine("\nEnter name only where first letter should be in Capital");
                }
            }

			//Taking pincode of the person from user.
			while (!validator.isValidZipCode(zip))
			{
				Console.WriteLine("Write pincode of the person");
				zip = Console.ReadLine();
                if (!validator.isValidZipCode(zip))
                {
                    Console.WriteLine("\nEnter number only as first digit can't be zero and length should be of six digit");
                }
            }

			//Taking phoneNumber of the person from user.
			while (!validator.isValidPhoneNumber(phoneNumber))
			{
				Console.WriteLine("Write phoneNumber of the person");
				phoneNumber = Console.ReadLine();
				if (!validator.isValidPhoneNumber(phoneNumber))
				{
					Console.WriteLine("\nNumber should start with [6-9] and must be of length 10");
				}
			}

			//Taking email of the person from user.
			while (!validator.isValidEmail(email))
			{
				Console.WriteLine("Write email of the person");
				email = Console.ReadLine();
                if (!validator.isValidEmail(email))
                {
                    Console.WriteLine("\nemail is of wrong format");
                }
            }

			Contact newObj = new Contact(firstName, lastName, address, city, state, zip, phoneNumber, email);
			data.dict.Add(newObj.FirstName, newObj);

			firstName = "";
			lastName = "";
			address = "";
			city = "";
			state = "";
			zip = "";
			phoneNumber = "";
			email = "";
			Console.Clear();
			Console.WriteLine("Contact successfully saved");
			Console.WriteLine("Press Enter to Exit");
			Console.ReadLine();
			Console.Clear();
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
				Console.WriteLine($"Contact with firstName {firstName} not Found\n");
			}
			Console.WriteLine("Press Enter to Exit");
			Console.ReadLine();
		}

		public void update(string firstName)
		{
			Console.Clear();

			//check whether the person with firstName available or not 
			if (!data.dict.ContainsKey(firstName)){
				Console.WriteLine("The Name does not exist\n");
				return;
			}

			Contact contact = data.dict[firstName];
			int flag = 1;
			while (flag==1)
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
						data.dict.Remove(contact.FirstName);
                        contact.FirstName = Console.ReadLine();
						data.dict.Add(contact.FirstName, contact);
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
                        Console.WriteLine("\nWrite the Pincode you want to change to");
                        contact.Pincode = Console.ReadLine();
                        break;
                    case 7:
						Console.WriteLine("\nWrite the Phone Number you want to change to");
						contact.PhoneNumber = Console.ReadLine();
						break;
					case 8:
						Console.WriteLine("\nWrite the Email you want to change to");
						contact.Email = Console.ReadLine();
						break;
					case 9:
						flag = 0;
						break;
					default:
						Console.WriteLine("\nInvalid Choice!: Choose from 1-8");
						break;
				}
			}
		}
        public void delete(string firstName)
        {
            Console.Clear();
            if (data.dict.ContainsKey(firstName))
            {
                data.dict.Remove(firstName);
                Console.WriteLine($"Contact with name {firstName} successfully deleted");
            }
            else
            {
                Console.WriteLine($"Contact with firstName {firstName} is not there\n");
            }
        }
		public void searchByCity(string cityName)
		{
			Console.Clear();
			bool found = true;
			int counter = 0;

			foreach (var contact in data.dict.Values)
			{
                if (contact.State.Equals(cityName, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"First Name: {contact.FirstName}");
                    Console.WriteLine($"Last Name: {contact.LastName}");
                    Console.WriteLine($"Address: {contact.Address}");
                    Console.WriteLine($"City: {contact.City}");
                    Console.WriteLine($"State: {contact.State}");
                    Console.WriteLine($"Pincode: {contact.Pincode}");
                    Console.WriteLine($"Phone Number: {contact.PhoneNumber}");
                    Console.WriteLine($"Email: {contact.Email}\n");

                    found = true;
                    counter++;
                }
            }

            if (!found)
            {
                Console.WriteLine($"No contacts found for city'{cityName}'.");
                Console.WriteLine("Press Enter to Exit");
                Console.ReadLine();
            }

			Console.WriteLine($"Total Contacts Found = {counter}");
			Console.WriteLine("Press Enter to Exit");
			Console.ReadLine();
		}
        public void searchByState(string stateName)
        {
            Console.Clear();
            bool found = true;
            int counter = 0;


			foreach (var contact in data.dict.Values)
			{
				if (contact.State.Equals(stateName, StringComparison.OrdinalIgnoreCase))
				{
					Console.WriteLine($"First Name: {contact.FirstName}");
					Console.WriteLine($"Last Name: {contact.LastName}");
					Console.WriteLine($"Address: {contact.Address}");
					Console.WriteLine($"City: {contact.City}");
					Console.WriteLine($"State: {contact.State}");
					Console.WriteLine($"Pincode: {contact.Pincode}");
					Console.WriteLine($"Phone Number: {contact.PhoneNumber}");
					Console.WriteLine($"Email: {contact.Email}\n");

					found = true;
					counter++;
				}
			}
            if (!found)
            {
				Console.WriteLine($"No contacts found for state'{stateName}'.");
            }

            Console.WriteLine($"Total Contacts Found = {counter}");
            Console.WriteLine("Press Enter to Exit");
            Console.ReadLine();
        }

		//Displays based on the state / city / FirstName ... after sorting Alphabetically
		public void Display()
		{
			// counter to check the amount of data stored in the particular dictionary
			int counter = 1;
			int choice;

			//Giving choice to choose to display using ..
            Console.WriteLine("1. Print after sorting FirstName");
            Console.WriteLine("2. Print after sorting cityName");
            Console.WriteLine("3. Print after sorting stateName");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid choice. Please enter a number.");
            }

			//Choice based scenario
			// 1 -> FirstName
			// 2 -> CityName
			// 3 -> StateName
			switch (choice)
			{
				case 1:
                    var sortedDictionary = data.dict.OrderBy(x => x.Key);
                    foreach (var item in sortedDictionary)
                    {
                        Console.WriteLine($"[{counter++}]");
                        Console.WriteLine($" \tFirstName: {item.Value.FirstName}");
                        Console.WriteLine($" \tLastName:  {item.Value.LastName}");
                        Console.WriteLine($" \tAddress:  {item.Value.Address}");
                        Console.WriteLine($" \tCity:  {item.Value.City}");
                        Console.WriteLine($" \tState: {item.Value.State}");
                        Console.WriteLine($" \tPincode: {item.Value.Pincode}");
                        Console.WriteLine($" \tPhoneNumber: {item.Value.PhoneNumber}");
                        Console.WriteLine($" \tEmail: {item.Value.Email}");
                    }
                    break;


				case 2:
                    sortedDictionary = data.dict.OrderBy(x => x.Value.City);
                    foreach (var item in sortedDictionary)
                    {
                        Console.WriteLine($"[{counter++}]");
                        Console.WriteLine($" \tFirstName: {item.Value.FirstName}");
                        Console.WriteLine($" \tLastName:  {item.Value.LastName}");
                        Console.WriteLine($" \tAddress:  {item.Value.Address}");
                        Console.WriteLine($" \tCity:  {item.Value.City}");
                        Console.WriteLine($" \tState: {item.Value.State}");
                        Console.WriteLine($" \tPincode: {item.Value.Pincode}");
                        Console.WriteLine($" \tPhoneNumber: {item.Value.PhoneNumber}");
                        Console.WriteLine($" \tEmail: {item.Value.Email}");
                    }
                    break;


				case 3:
					sortedDictionary = data.dict.OrderBy(x => x.Value.State);
                    foreach (var item in sortedDictionary)
                    {
                        Console.WriteLine($"[{counter++}]");
                        Console.WriteLine($" \tFirstName: {item.Value.FirstName}");
                        Console.WriteLine($" \tLastName:  {item.Value.LastName}");
                        Console.WriteLine($" \tAddress:  {item.Value.Address}");
                        Console.WriteLine($" \tCity:  {item.Value.City}");
                        Console.WriteLine($" \tState: {item.Value.State}");
                        Console.WriteLine($" \tPincode: {item.Value.Pincode}");
                        Console.WriteLine($" \tPhoneNumber: {item.Value.PhoneNumber}");
                        Console.WriteLine($" \tEmail: {item.Value.Email}");
                    }
                    break;


				default:
					Console.WriteLine("Invalid Choice choose(1-3)");
					break;


			}

			//If Present AddressBook is Empty
            if (counter == 1)
            {
                Console.WriteLine("AddressBook is Empty");
            }
            Console.WriteLine("Press Enter to Exit");
            Console.ReadLine();
            Console.Clear();

        }

		//ReadFile reads the file and then all Add_Contact feature.
        public void ReadFile()
        {
			//FilePath
            string path = @"/Users/anandkunalmishra/Desktop/untitled folder/file.txt";

			//Creating the reader -> StreamReader obj which allow to read file 
            using (StreamReader reader = new StreamReader(path))
            {
				//Variables declaration ...
                string line;
				int counter = 0;
				int lineCount = 0;
                int flag = 0;

                //Below line will run upto the file is not empty.
                while ((line = reader.ReadLine()) != null)
                {
					//lineCount monitors the line where we have the error.
					lineCount++;

					//input array creation which splits the file line by line and keeping it as an Array
                    string[] input = line.Split(',');
					
					if (input.Length >= 8)
					{
						//flag acts as a checker so to filter the correctly formated entery
						flag = 1;

						//Taking the enteries of the Line and adding it to allocated variables
						firstName = input[0];
                        lastName = input[1];
                        address = input[2];
                        city = input[3];
                        state = input[4];
                        zip = input[5];
                        phoneNumber = input[6];
                        email = input[7];

                        if (data.dict.ContainsKey(firstName))
                        {
                            Console.WriteLine($"User Already Exist for Line {lineCount}\n");
							flag = 0;
							continue;
                        }

                        //checks if the Name is valid
                        else if (!validator.isValidName(firstName))
						{
							Console.WriteLine($"The Error is in Line {lineCount}");
							Console.WriteLine("FirstName is in improperformat\n");
							flag = 0;
						}
						

						//checks if the lastName is valid
                        else if (!validator.isValidName(lastName))
                        {
							Console.WriteLine($"The Error is in Line {lineCount}");
                            Console.WriteLine("LastName is in improperformat\n");
                            flag = 0;
                        }

						//checks whether the city name is valid 
						else if (!validator.isValidName(city))
                        {
							Console.WriteLine($"The Error is in Line {lineCount}");
                            Console.WriteLine("City is in improperformat\n");
                            flag = 0;
                        }

						//checks if the state name is valid 
						else if (!validator.isValidName(state))
						{
                            Console.WriteLine($"The Error is in Line {lineCount}");
                            Console.WriteLine("State is in improperformat\n");
                            flag = 0;
                        }

						//checks if the zipCode is Valid for the particular line
						else if (!validator.isValidZipCode(zip))
                        {
                            Console.WriteLine($"The Error is in Line {lineCount}");
                            Console.WriteLine("Pincode is in improperformat\n");
                            flag = 0;
                        }

						//checks if the phoneNumber is valid for the particular line
						else if (!validator.isValidPhoneNumber(phoneNumber))
                        {
                            Console.WriteLine($"The Error is in Line {lineCount}");
                            Console.WriteLine("PhoneNumber is in improperformat\n");
                            flag = 0;
                        }

						//checks if email is valid for the line 
                        else if (!validator.isValidEmail(email))
                        {
                            Console.WriteLine($"The Error is in Line {lineCount}");
                            Console.WriteLine("Email is in improperformat\n");
                            flag = 0;
                        }

						//Checking the Flag so that we can confirm that all entry are valid 
						if (flag == 1)
						{
                            Contact newContact = new Contact(firstName, lastName, address, city, state, zip, phoneNumber, email);
                            data.dict.Add(newContact.FirstName, newContact);
							Console.WriteLine($"User is Successfully Created for Line{lineCount}\n");
                            counter++;
                        }
                    }
                }
                if (flag == 0)
                {
                    Console.WriteLine();
                }
                Console.WriteLine($"The Total contact created is {counter}");
				Console.WriteLine("Press Enter to Exit");
				Console.ReadLine();
				Console.Clear();
            }
        }
		public void writeFile()
		{
			//FilePath
			string output = @"/Users/anandkunalmishra/Desktop/untitled folder/output.txt";

            using (FileStream fs = new FileStream(output, FileMode.OpenOrCreate,FileAccess.ReadWrite))
			{
                using (StreamWriter writer = new StreamWriter(fs))
                {
                    // counter to check the amount of data stored in the particular dictionary
                    int counter = 1;
                    int choice;

                    //Giving choice to choose to display using ..
                    Console.WriteLine("1. Print after sorting FirstName");
                    Console.WriteLine("2. Print after sorting cityName");
                    Console.WriteLine("3. Print after sorting stateName");

                    if (!int.TryParse(Console.ReadLine(), out choice))
                    {
                        Console.WriteLine("Invalid choice. Please enter a number.");
                    }

                    //Choice based scenario
                    // 1 -> FirstName
                    // 2 -> CityName
                    // 3 -> StateName
                    switch (choice)
                    {
                        case 1:
                            var sortedDictionary = data.dict.OrderBy(x => x.Key);
                            foreach (var item in sortedDictionary)
                            {
                                writer.WriteLine($"[{counter++}]");
                                writer.WriteLine($" \tFirstName: {item.Value.FirstName}");
                                writer.WriteLine($" \tLastName:  {item.Value.LastName}");
                                writer.WriteLine($" \tAddress:  {item.Value.Address}");
                                writer.WriteLine($" \tCity:  {item.Value.City}");
                                writer.WriteLine($" \tState: {item.Value.State}");
                                writer.WriteLine($" \tPincode: {item.Value.Pincode}");
                                writer.WriteLine($" \tPhoneNumber: {item.Value.PhoneNumber}");
                                writer.WriteLine($" \tEmail: {item.Value.Email}");
                            }
                            break;


                        case 2:
                            sortedDictionary = data.dict.OrderBy(x => x.Value.City);
                            foreach (var item in sortedDictionary)
                            {
                                writer.WriteLine($"[{counter++}]");
                                writer.WriteLine($" \tFirstName: {item.Value.FirstName}");
                                writer.WriteLine($" \tLastName:  {item.Value.LastName}");
                                writer.WriteLine($" \tAddress:  {item.Value.Address}");
                                writer.WriteLine($" \tCity:  {item.Value.City}");
                                writer.WriteLine($" \tState: {item.Value.State}");
                                writer.WriteLine($" \tPincode: {item.Value.Pincode}");
                                writer.WriteLine($" \tPhoneNumber: {item.Value.PhoneNumber}");
                                writer.WriteLine($" \tEmail: {item.Value.Email}");
                            }
                            break;


                        case 3:
                            sortedDictionary = data.dict.OrderBy(x => x.Value.State);
                            foreach (var item in sortedDictionary)
                            {
                                writer.WriteLine($"[{counter++}]");
                                writer.WriteLine($" \tFirstName: {item.Value.FirstName}");
                                writer.WriteLine($" \tLastName:  {item.Value.LastName}");
                                writer.WriteLine($" \tAddress:  {item.Value.Address}");
                                writer.WriteLine($" \tCity:  {item.Value.City}");
                                writer.WriteLine($" \tState: {item.Value.State}");
                                writer.WriteLine($" \tPincode: {item.Value.Pincode}");
                                writer.WriteLine($" \tPhoneNumber: {item.Value.PhoneNumber}");
                                writer.WriteLine($" \tEmail: {item.Value.Email}");
                            }
                            break;


                        default:
                            Console.WriteLine("Invalid Choice choose(1-3)");
                            break;


                    }

                    //If Present AddressBook is Empty
                    if (counter == 1)
                    {
                        Console.WriteLine("AddressBook is Empty");
                    }
                    writer.Flush();
                    writer.Close();

                    Console.WriteLine("Press Enter to Exit");
                    Console.ReadLine();
                    Console.Clear();

                    
                }
            }

        }
    }
}