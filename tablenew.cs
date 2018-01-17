using System;

class mainclass
{
	public static void Main(string[]args)
	{
		int i,num,tab=0;
		Console.WriteLine("\n\t\t\t PLEASE ENTER A NUMBER FOR PRINT TABLE");
		num=Convert.ToInt32(Console.ReadLine());
		i=1;
		do
		{
			tab=num*i;
			Console.WriteLine(tab);
			i++;
		}while(i<=10);
Console.Read();
	}
}