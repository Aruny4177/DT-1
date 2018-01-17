using System;
	using System.Collections.Generic;
	using System.Text;
	namespace BinaryOverload 
	{
		class Calculator
		{
			public int number;
			public Calculator()
			{
				number = 0;
			}
		public Calculator(int n)
		{
            number = n;
		}
		public static Calculator operator +(Calculator 		Calc1,Calculator Calc2)
		{
			Calculator Calc3 = new Calculator(0); 
			Calc3.number = Calc2.number + Calc1.number;
			return Calc3;
        }
	public void display()
	{	
		Console.WriteLine("{0}", number);
	}
	}
    class CalNum 
    {
		static int Main(string[] args)
		{ 
			Calculator num1 = new Calculator(100); 
			Calculator num2 = new Calculator(50); 
			Calculator num3 = new Calculator(); 
			num3 = num1 + num2; 
		  num1.display();	 //Displays 100
         num2.display();	 //Displays 50 
         num3.display();	 //Displays 150
         Console.ReadLine();
         return 0;
       }
      }
	  }

