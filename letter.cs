using System;
class Program
{
	public static void Main(string[] args)
	{
	int test1,test2;
	Console.WriteLine("Enter the test1 percent");
	test1 = Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("Enter the test2 percent");
	test2 = Convert.ToInt32(Console.ReadLine());
	if(test1 >= 80)
	{
		if(test2 >= 80)
		{
			Console.WriteLine("theinterview letter send");
		}
		else
		{
				Console.WriteLine("the rejection letter is send");
		}
	}
	else
	{
		Console.WriteLine("the rejection letter is send");
	}
	
	}
}