using System.Collections.Generic;
namespace Address_Book
{
    class Program
    {

        public static void Main(string[] args)
        {
            Database addressBook = new Database();

            while (true)
            {
                Console.WriteLine("Chosse an operation");
                Console.WriteLine("1. Adding a contact");
                Console.WriteLine("2. Reading a contact");
                Console.WriteLine("3. Display all contacts");
                Console.WriteLine("4. Update a contact");
                Console.WriteLine("5. Exit");

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
                        DisplayAllContacts(addressBook);
                        break;
                    case 4:
                        UpdateContact(addressBook);
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    case 6:
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
            operation.retrieve();
        }

        static void DisplayAllContacts(Database addressbook)
        {

        }

        static void UpdateContact(Database addressbook)
        {

        }

    }
}
