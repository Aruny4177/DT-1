using System;
sealed class sc
{
	public int add(int x,int y)
	{
		return x+y;
	}
}

public class derive
{
	public static void Main(String[]args)
	{
		sc obj=new sc();
		int total=obj.add(10,3);
		Console.WriteLine("\n\t\t\t Total={0}",total);
	}
}