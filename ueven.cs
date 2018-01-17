using System;
class Program
{
	public static void Main(string[] args)
	{
		int number,age;
		string userid,password,name;
		Console.WriteLine("Enter user id");
		userid = Console.ReadLine();
		Console.WriteLine("Enter the pasword");
		password = Console.ReadLine();
		if((userid == "niit")&&(password == "123"))
		{
			Console.WriteLine("WELCOME , USER");
			Console.WriteLine("Enter name");
			name= Console.ReadLine();
			Console.WriteLine("Enter age");
			age = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("your name and age is :{0} {1}",name,age);
			Console.WriteLine("Enter Number");
			number=Convert.ToInt32(Console.ReadLine());
			// Check Even or Odd
			if (number % 2 == 0)
			{
				Console.WriteLine("this number is even");
			}
			else
			{
			Console.WriteLine("this number is odd");
			}
		}
		
	}
}