using System;
class TABLE
{
    public static void Main(string[] args)
	{
		string name;
		int i;
		Console.WriteLine("Enter the name ");
		name = Console.ReadLine();
		for(i=1; i<=5; i++)
		{
			Console.WriteLine("my name is {0}",name);
		}
		Console.ReadLine();
	}
}