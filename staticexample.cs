using System;

public class staticexample
{
	public static int ivar;
	string name;
	public static void set()
	{
		ivar=20;
//		name="atul Kumar pandey";
	}
	
}

public class program
{
	public static void Main(String[]args)
	{
		staticexample.ivar=1;
		Console.WriteLine(staticexample.ivar.ToString());
		
		/*staticexample ex=new staticexample();
		ex.set();*/

		staticexample.set();

		Console.WriteLine(staticexample.ivar.ToString());

	}
}