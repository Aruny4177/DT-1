using System;
class maths_sol
{
	public static void Main(string[] args)
	{
		int first_number;
		int second_number;
		int sum;
		int sub;
		Console.WriteLine("Enter the first number");
		first_number = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter the second number");
		second_number = Convert.ToInt32(Console.ReadLine());
		sum = first_number + second_number;
		sub = first_number - second_number;
		Console.WriteLine("Sum and Sub is :{0} {1}",sum,sub);
	}
}