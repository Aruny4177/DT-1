using System;
using System.Collection.Generic;
using Sytstem.Text;

class divisble
{
	static void Main(string[] args)
	{
		int num1,num2,result;
		Console.WriteLine("Enter FIrst Number");
		num1 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter Second number");
		num2 = Convert.ToInt32(Console.ReadLine());
		if ( num2 ==0)
		{
		     Console.WriteLine("You cannot divide by 0");
		}
		else
		{
		  result = num1 %  num2;
		  if (result == 0)
		   Console.WriteLine("Divisible");
		   else
		Console.WriteLine("Not Divisible");
		}
	}
}
