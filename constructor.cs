using System;
class calculator
{
	int a,b,res;
	public calculator()
	{
		a=4;
		b=5;
	}
	public void set(int x,int y)
	{	
		a=x;
		b=y;
	}	
	public void Add()
	{
		res=a+b;
		Console.WriteLine("rEsult="+res);
	}
}
class mainclass
{
	static void Main(String[]args)
	{
		calculator calc=new calculator();
		//calc.set(33,3);
		calc.Add();
	}
}