using System;

public class mainclass
{
	public static void Main(string[]args)
	{
		int a,b,result;
		
			Console.WriteLine("\t\t\t Enter A first value:  ");
			a=Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("\t\t\t\t Enter Second value:  ");
			b=Convert.ToInt32(Console.ReadLine());
			if((b==0)||(b>a))
			{
				Console.WriteLine("\t\t\t\t  PLEASE ENTER A VALID NUMBER");
			}
			else
			{
				result=a/b;
				Console.WriteLine("result= {0}",result);
			}
		
	}	
}