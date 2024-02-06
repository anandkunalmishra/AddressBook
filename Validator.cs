using System.Text.RegularExpressions;

namespace Address_Book
{
	public class Validator
	{
		public bool isValidEmail(string str)
		{
			string validator = "^[a-zA-Z0-9+-.]+@[a-zA-Z]+\\.[a-z]{2,}$";
            bool input = Regex.IsMatch(str, validator);
            return input;
        }
		public bool isValidName(string str)
		{
            string validator = "^[A-Z][a-z]*$";
            bool input = Regex.IsMatch(str, validator);
            return input;
        }
        public bool isValidZipCode(string str)
        {
            string validator = "^[1-9]\\d{5}$";
            bool input = Regex.IsMatch(str, validator);
            return input;
        }
		public bool isValidPhoneNumber(string str)
		{
            string validator = "^[6-9]\\d{9}$";
            bool input = Regex.IsMatch(str,validator);
            return input;
        }
    }
}

