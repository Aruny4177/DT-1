using System;
class identify
{
	public static void Main(string[] args)
	{
		string user_name;
		string password;
		Console.WriteLine("Enter the NAME");
		user_name = Console.ReadLine();
		Console.WriteLine("Enter the password");
		password = Console.ReadLine();
		if((user_name == "ARUN")&&(password == "123"))
		{
		Console.WriteLine("wlecome to home");
		}
		else
		{
		 Console.WriteLine("sry plz Enter you valid username or passwprd");
		}
	}
}