using System;
public class A
{
	public A()//default constructor
	{
	}
	public void display()
	{
		Console.WriteLine("\n\t\t\t Hello");
	}
	
}
class exa
{
	public static void Main(String[]args)
	{
		A  obja=new A();
		obja.display();
	}
}