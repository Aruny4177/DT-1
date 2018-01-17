using System;
class Distance
	{
	  int dist;
	  public Distance(int d)
  	{
		this.dist = d;
  	}
	  public static Distance operator +(Distance d1,  Distance d2)
  	{
		return new Distance(d1.dist + d2.dist);
  	}
	public void showdistance()
	{
		Console.WriteLine("\n\t\t\t Distance ="+this.dist);
	}
	}

class Program
    {
    static void Main(string[] args)
	{	
	   Distance d1 = new Distance(3);
        Distance d2 = new Distance(10);
        Distance d3;
        d3 = d1 + d2;
        d3.showdistance();
	d1.showdistance();
	d1=d3+d2;
	d2.showdistance();
	d1.showdistance();
		}
		}

