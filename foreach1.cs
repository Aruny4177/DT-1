using System;
class mainclass
{
	static void Main(String[]args)
	{
		int []array={4,5,33,44};
		
		foreach(int value in array)
		{
			Console.Write("["+value+"]");
		}
	}
}