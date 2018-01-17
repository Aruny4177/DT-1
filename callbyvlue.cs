using System;
public class calculator
{
	public void addone(int var)
	{
		var--;
		Console.WriteLine("\n\t\t\t var={0}",var);
	}
	
	static void Main(String[]args)
	{
		calculator cal=new calculator();
		int number=6;
		cal.addone(number);
		Console.WriteLine("\n\t\t\t Number={0}",number);
	}
}