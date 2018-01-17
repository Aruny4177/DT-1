using System;
class Program
{
	public static void Main(string[] args)
	{
		int weekday;
		Console.WriteLine("Enter the weekday");
		weekday =Convert.ToInt32(Console.ReadLine());
		switch (weekday)
		{
			case 1 : Console.WriteLine("MONDAY");
			break;
			case 2 :Console.WriteLine("TUESDAY");
			break;
			case 3 :Console.WriteLine("wednesday");
			break;
			case 4 :Console.WriteLine("thursday");
			break;
			case 5 :Console.WriteLine("friday");
			break;
			case 6 :Console.WriteLine("saturday");
			break;
			case 7 :Console.WriteLine("sunday");
			break;
			default : Console.WriteLine("no weekday");
			break;
			
		}
	}
}