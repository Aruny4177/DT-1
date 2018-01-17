using System;
class table
{
	
	public static void Main(string[]args)
	{
		int i,num,tab=0;
		Console.WriteLine(" PLEASE ENTER A NUMBER FOR PRINT TABLE");
		num=Convert.ToInt32(Console.ReadLine());
		
		for(i=1;i<=10;i++)
		{
			tab=num*i;
			Console.WriteLine(tab);
			
		}
		Console.Read();
	}

}