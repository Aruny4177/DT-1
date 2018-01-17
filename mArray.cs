using System;
class Program
{
	public static void Main(string[] args)
	{
		char[,]mArray = new char[2,4]{
		{'A','R','U','N'},
		{'A','B','H','I'}};
		for (int i= 0; i<2; i++)
		{
			for(int j=0; j<4; j++)
			{
				Console.Write("{0} \t", mArray[i, j]);
			}
			Console.WriteLine();
		}
		Console.ReadLine();
		
	}
}