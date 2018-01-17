using System;
class star
{
	public static void Main(string[] args)
	{
		int i,j,k=1;
		for(i=1;i<=4;i++)
		{
			for(j=1;j<=i;j++)
			{
				Console.Write(k++);
			}
			Console.WriteLine();
		}
		
	}
}