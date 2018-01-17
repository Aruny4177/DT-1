using System;
class Program
{
	public static void Main(string[] args)
	{
		string userid,password;
		Console.WriteLine("Enter the userid");
		userid = Console.ReadLine();
		Console.WriteLine("Enter the pasword");
		password = Console.ReadLine();
		if (userid == "ARUN")
		{
			if (password == "12345")
			{
				Console.WriteLine("you have valid user");
			}
			else
			{
				Console.WriteLine("SORY U HAVE ENTER A ICCORRECT pasword");
			}
		}
		else
		{
			Console.WriteLine("WELCOME TO HOME");
		}
	}
	
}