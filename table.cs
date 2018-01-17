using System;
class TABLE
{
    public static void Main(string[] args)
	{
		int t,i;
		Console.WriteLine("This is the program of printing table of any digit");
		Console.WriteLine("Enter the table digit,which you want to print the table");
		t =Convert.ToInt32(Console.ReadLine());
		for(i=1; i<=10; i++)
		{
			Console.WriteLine("The table of"+t+"is {0}",(t*i));
		}
		Console.ReadLine();
	
	}
}