using System;

class array
{
	public static void Main(string[]args)
	{
		int[]array=new int[10];
		Console.WriteLine("\n\t\t\t PLEASE ENTER TEN VALUES");
		for(int i=0;i<10;i++)
		{
			array[i]=Convert.ToInt32(Console.ReadLine());
		}
		Console.WriteLine("\n\t\t\t TEN VALUES OF ARRAY");
		for(int i=9;i>=0;i--)
		{
				Console.WriteLine("["+array[i]+"]");
		}
	}
}