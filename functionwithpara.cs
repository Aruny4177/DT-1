using System;

public class A
{
	public string name;
	public int age;
	public void setvalue()
	{
		Console.WriteLine("enter your name");
		name=Console.ReadLine();
	}
}

public class B
{
	public A getvalue(A obja)
	{
		Console.WriteLine("hello {0}",obja.name);
		Console.WriteLine("enter your age");
		obja.age=Convert.ToInt32(Console.ReadLine());
		return obja;		
	}
	
}
public class mainclass
{
	public static void Main(string[]args)
	{
		A obja=new A();
		obja.setvalue();
		B objb=new B();
		A objanew=objb.getvalue(obja);
		Console.WriteLine("hello {0} and your age {1}",obja.name,objanew.age);

	}
}