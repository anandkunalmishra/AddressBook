namespace Address_Book
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Create an instance of the Contact class
            Contact obj = new Contact("Anand", "Kunal", "GH-168", "ranchi", "jharkhand", "834004", "9934311972", "anandkunalmishra@gmail.com");

            // Accessing the properties using getters
            Console.WriteLine("Welcome to the Address book");
            Console.WriteLine($"First Name: {obj.FirstName}");
            Console.WriteLine($"Last Name: {obj.LastName}");
            Console.WriteLine($"Address: {obj.Address}");
            Console.WriteLine($"City: {obj.City}");
            Console.WriteLine($"State: {obj.State}");
            Console.WriteLine($"Pincode: {obj.Pincode}");
            Console.WriteLine($"Phone Number: {obj.PhoneNumber}");
            Console.WriteLine($"Email: {obj.Email}");
        }
    }
}
