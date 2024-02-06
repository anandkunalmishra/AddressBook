using System.Collections.Generic;
namespace Address_Book
{
    class Program
    {

        public static void Main(string[] args)
        {
            
            Database addressBook = new Database();

            int flag = 1;
            while (flag == 1)
            {
                Console.Clear();
                Console.WriteLine("Chosse an operation");
                Console.WriteLine("1. Adding a contact");
                Console.WriteLine("2. Reading a contact");
                Console.WriteLine("3. Delete a contact");
                Console.WriteLine("4. Update a contact");
                Console.WriteLine("5. Search a contact");
                Console.WriteLine("6. Display all contact");
                Console.WriteLine("7. Exit");

                int choice;


                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid choice. Please enter a number.");
                    continue;
                }


                /*
                 *  int.TryParse(input, out choice): 
                 *
                 *      -> This method attempts to parse the input string into an integer. 
                 *      -> It returns true if the parsing succeeds, and the parsed integer value is stored in the choice variable. 
                 *      -> If parsing fails, it returns false. 
                 *      
                 */


                switch (choice)
                {
                    case 1:
                        AddContact(addressBook);
                        break;
                    case 2:
                        RetrieveContact(addressBook);
                        break;
                    case 3:
                        DeleteContact(addressBook);
                        break;
                    case 4:
                        UpdateContact(addressBook);
                        break;
                    case 5:
                        SearchByStateorCity(addressBook);
                        break;
                    case 6:
                        displayContact(addressBook);
                        break;
                    case 7:
                        flag = 0;
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please enter number between 1 and 5");
                        break;
                }
            }
        }

        static CRUD operation = new CRUD();

        static void AddContact(Database addressbook)
        {
            operation.create();
        }

        static void RetrieveContact(Database addressbook)
        {
            Console.Clear();
            Console.WriteLine("Write the firstName of the person");
            string firstName = Console.ReadLine();
            operation.retrieve(firstName);
        }

        static void UpdateContact(Database addressbook)
        {
            Console.Clear();
            Console.WriteLine("\nWrite the firstName");
            string firstName = Console.ReadLine();
            operation.update(firstName);
        }

        static void DeleteContact(Database addressbook)
        {
            Console.Clear();
            Console.WriteLine("\nWrite the firstName");
            string firstName = Console.ReadLine();
            operation.delete(firstName);
        }
        static void SearchByStateorCity(Database addressbook)
        {
            Console.Clear();
            int choice;
            Console.WriteLine("Choose which option you want");
            Console.WriteLine("1. State");
            Console.WriteLine("2. City");
            if(!int.TryParse(Console.ReadLine(),out choice))
            {
                Console.WriteLine("Only Number to be entered");
                return;
            }

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the stateName for which you want to search for");
                    string stateName = Console.ReadLine();
                    operation.searchByState(stateName);
                    break;
                case 2:
                    Console.WriteLine("Enter the cityName for which you want to search for");
                    string cityName = Console.ReadLine();
                    operation.searchByCity(cityName);
                    break;
                default:
                    Console.WriteLine("Invalid Choice! Choose only for 1 and 2");
                    break;
            }
        }
        static void displayContact(Database addressbook)
        {
            Console.Clear();
            operation.Display();
        }
    }
}
