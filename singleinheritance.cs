using System;
public class A
{
	public void Add()
	{
		int a,b,res;
		Console.WriteLine("\n\t\t\t Please enter two values");
		a=Convert.ToInt32(Console.ReadLine());
		b=Convert.ToInt32(Console.ReadLine());
		res=a+b;
		Console.WriteLine("\n\t\t\t Result={0}",res);
	}
}

public class B:A
{
	public void Sub()
	{
		int a,b,res;
		Console.WriteLine("\n\t\t\t Please enter two values");
		a=Convert.ToInt32(Console.ReadLine());
		b=Convert.ToInt32(Console.ReadLine());
		res=a-b;
		Console.WriteLine("\n\t\t\t Result={0}",res);
	}
}
public class mainclass
{
	public static void Main(String[]args)
	{
		B objb=new B();
		objb.Sub();
		objb.Add();
	}
}