using System;
namespace Address_Book
{
	public class Database
	{
		Dictionary<string, Contact> dict;

		public Database()
		{
			dict = new Dictionary<string, Contact>();
		}
	}
}

