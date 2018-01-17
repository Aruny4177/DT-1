using System;
	namespace Destructors
	{
    class Calculator
    {
        static int number1, number2, total;
        public void AddNumber()
        {
            total= number1+number2;
	Console.WriteLine("The Result is {0}", total);
	}
	Calculator () //Constructor
	{
		number1=20;
		number2=30; 
		total=0;
		Console.WriteLine ("Constructor Invoked");
	}
	~Calculator () //Destructor
	{
		Console.WriteLine ("Destructor Invoked ");
	}
        static void Main(string[] args)
        {
            Calculator c1=new Calculator ();
            c1.AddNumber();
        }
    }
}

