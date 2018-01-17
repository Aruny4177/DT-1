using System;
class EVEN
{
	public static void Main(string[] args)
	{
		int number ;
		Console.WriteLine("Enter the nuber to find even or odd");
		number = Convert.ToInt32(Console.ReadLine());
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