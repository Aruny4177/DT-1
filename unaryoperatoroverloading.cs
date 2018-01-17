using System;
	namespace Calculator
	{
		class Calculator
		{
			public int number1, number2;
			public Calculator(int num1, int num2)
			{
			 	number1 = num1;
				number2 = num2;
			}
		public static Calculator operator -(Calculator c1)
		{
		c1.number1 = -c1.number1;
		c1.number2 = -c1.number2;
			return c1;
		}
		public void Print()
		{
		Console.WriteLine(" number1=" +number1);
						Console.WriteLine(" number2=" +number2);
						Console.ReadLine();
		}
	}
	class EntryPoint 
	{
		static void Main()
		{
			Calculator calc = new Calculator(15, -25);
			/*using the overloaded – operator with the class object */
          			calc = -calc; 
			calc.Print();
        }
   } 
 }

