namespace Address_Book
{
    public class Contact
    {
        private string firstName;
        private string lastName;
        private string address;
        private string city;
        private string state;
        private string zip;
        private string phoneNumber;
        private string email;

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

        //First Name getter and setter
        public string FirstName
        {
            get { return firstName; }
            set { this.firstName = value; }
        }


        //LastName getter and setter
        public string LastName
        {
            get { return lastName; }
            set { this.lastName = value; }
        }


        //Address getter and setter
        public string Address
        {
            get { return address; }
            set { this.address = value; }
        }


        //City getter and setter
        public string City
        {
            get { return city; }
            set { this.city = value; }
        }


        // State getter and setter
        public string State
        {
            get { return state; }
            set { this.state = value; }
        }


        //Pincode getter and setter
        public string Pincode
        {
            get { return zip; }
            set { this.zip = value; }
        }


        //Phone Number getter and setter
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { this.phoneNumber = value; }
        }


        //Email getter and setter
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

    }
}

