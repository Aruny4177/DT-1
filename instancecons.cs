	using System;
	namespace Calc
	{
    class Calculator
    {
		static int number1, number2, total;
		Calculator()
 		{
            number1 = 10;
            number2 = 20;
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
            Calculator c1 = new Calculator ();
            c1.AddNumber ();
            c1.DisplayNumber ();
       }}}        
