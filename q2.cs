using System;
namespace score
{
	class program
	{
		static void Main (string [] args)
		{
			int [] a = new int [100];
			Console.Write("Enter the number of recent matches for which the score of the batsman need to be analyzed: ");
			int x =Convert.ToInt32(Console.ReadLine());
			 
			Console.WriteLine("----");
			Console.WriteLine("Enter the Scores:");
			for (int j = 0; j < x; j++)
			{
				string s1 = Console.ReadLine();
				a[j] = Int32.Parse(s1);
			}
			int limit = x-1;
			for(int pass = 0; pass < x-1; pass++)
			{
				for (int j = 0; j < limit-pass; j++)
				{
					if (a[j]>a[j+1])
					{
						int k =a[j];
						a[j]=a[j+1];
						a[j+1]=k;
					}
				}
			}
			Console.WriteLine("\n\t\t\t After Sorting original Scores");
			for(int i=0;i<x-1;i++)
			{
				Console.Write("[{0}]",a[i]);
			}
		}
	}
}