using System;
class mainclass
{
	public static void Main(String[]args)
	{
		int choice;
		Console.WriteLine("\n\t\t\t PLEASE ETNER A VALUE BETWEEN 1 TO 7");
		choice=Convert.ToInt32(Console.ReadLine());
		switch(choice)
		{
			case 1:
				Console.WriteLine("Monday");
			break;
			case 2:
				Console.WriteLine("Tuesday");
			break;
			case 3:
				Console.WriteLine("Wednesday");
			break;
			case 4:
				Console.WriteLine("Thursday");
			break;
			case 5:
				Console.WriteLine("Friday");
			break;
			case 6:
				Console.WriteLine("Saturday");
			break;
			case 7:
				Console.WriteLine("Sunday");
			break;
			default:
				Console.WriteLine("Sorry there is not more then seven weaks");
			break;	
		}
	}
}