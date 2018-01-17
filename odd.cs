using System;
class program
{
	public static void Main(string[]args)
	{
		int num;
		Console.WriteLine("Enter your number : ");
		num = Convert.ToInt32(Console.ReadLine());
		if(num % 2 == 0)
		{
			Console.WriteLine("even");
		}
		else
		{
			Console.WriteLine("odd");
		}
	}
}