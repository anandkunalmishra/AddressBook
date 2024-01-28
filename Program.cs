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
                }
            }
        }
        static void AddContact(Database addressbook)
        {

        }
        static void RetrieveContact(Database addressbook)
        {

        }
        static void DisplayAllContacts(Database addressbook)
        {

        }
        static void UpdateContact(Database addressbook)
        {

        }
    }
}
