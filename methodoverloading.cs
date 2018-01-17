using System;
namespace CalculateMax 
{    
    class CalculateMax 
    {
        public int Max(int number1, int number2)
        {
            if (number1 > number2)
            {
                return number1;
            }
            else
            {
                return number2; 
		   } }
	   public float Max(float number1, float number2)
	{
		if (number1 > number2)
		{
			return number1;
		}
		else
		{
			return number2;
		}
	}
}
	class MaxCalc 
{
	static int Main(string[] args)
	{
		CalculateMax calc = new CalculateMax();
		Console.WriteLine("{0}", calc.Max(5.4F, 8.6F)); 
    //Both function calls differ
	 Console.WriteLine("{0}", calc.Max(19, 12));
	//only in their parameters
	Console.ReadLine();
	return 0;
	}   
}	
}

