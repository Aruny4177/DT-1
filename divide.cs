using System;

public class mainclass
{
	public static void Main(String[]args)
	{
		int a,b,res;
		do
		{
		Console.WriteLine("\n\t\t\t PLEASE ENTER FIRST NO");
		a=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("\n\t\t\t PLEASE ENTER SECOND NO");
		b=Convert.ToInt32(Console.ReadLine());
		if(b==0)
		{
			Console.WriteLine("\n\t\t\t Sorry Please enter a valid no");
		}
		else
		{
		res=a/b;
		Console.WriteLine("\n\t\t\t Result={0}",res);
		}
		Console.WriteLine("\n\t\t\t Do you want to continue (1->yes 0-> No)");
		res=Convert.ToInt32(Console.ReadLine());
		}while(res!=0);
	}
}