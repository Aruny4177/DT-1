using System;
	namespace Calc
	{
 	class Calculator
	{
   	 static int number1, number2, total;  //Constructor defined with two integer  
	Calculator(int num1, int num2)
	{
		    number1 = num1;
            number2 = num2;
        }
        public void AddNumber()
        {
            total = number1 + number2;
        }
        public void DisplayNumber()
        {
          Console.WriteLine("The Total is :{0}", total);
        }
        public static void Main(string[] args)
  		{
          int var1, var2;
		Console.WriteLine("Enter Value 1:");
		var1=Convert.ToInt16(Console.ReadLine());
		Console.WriteLine("Enter Value 2  :");
		var2 = Convert.ToInt16(Console.ReadLine());
		Calculator C1 = new Calculator(var1,var2);
		C1.AddNumber();
		C1.DisplayNumber();
		Console.ReadLine();
     }
    }
	}

