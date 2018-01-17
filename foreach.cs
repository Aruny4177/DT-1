using System;
class foreach
{
    public static void Main(string[] args)
	{
		int [] Numbers = {4,3,2,1,0,-1,-2,9,5};
		Console.WriteLine("The content of an array is:");
		foreach(int k in Numbers)
		{
			Console.Write("{0} /t",k);
		}
	}
	
}