using System;
	class Base
	{		public Base()
		{
			Console.WriteLine("Constructor of Base");
		}
	     ~Base()
		{
			Console.WriteLine("Destructor of Base"); 
		} 
	}
	class Derived : Base
	{
    	public Derived()
    	{
        Console.WriteLine("Constructor of Derived");
		}
		~Derived()
      	{
        Console.WriteLine("Destructor of Derived");
        }
	}
	class BaseDerived 
	{
	  static int Main(string[] args)
	  {
     Derived obj = new Derived();
     return 0;   
 	  }
	} 
 