using System;

class delegateexample
{
	public static void display(string name)
	{
		Console.WriteLine("hello "+name);
	}
	public delegate void mydelegate(string name);
	
	
	public static void usemethod(mydelegate objdel)
	{
		objdel("Raman");
	}

	public static void Main(string[]args)
	{
		mydelegate objd=new mydelegate(display);
		usemethod(objd);
		Console.WriteLine();
		
	}
	

}