using System;
public class calculatedistance
{
	double distance,meter;
	public void setdistance()
	{
		Console.WriteLine("\n\t\t\t PLEASE ENTER A VALUE FOR KILOMETER");
		distance=Convert.ToDouble(Console.ReadLine());
	}
	public void Convertintometer()
	{
		meter=distance*1000;
	}
	public void getdistance()
	{
		Console.WriteLine("\n\t\t\t Your distance in meters are={0}",meter);
	}
}
class mainclass
{
	public static void Main(String[]args)
	{
		calculatedistance objd=new calculatedistance();
		objd.setdistance();
		objd.Convertintometer();
		objd.getdistance();
		
	}
}