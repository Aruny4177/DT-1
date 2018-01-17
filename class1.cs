using System;

public class student
{
	string name;
	public void setvalue()
	{
		Console.WriteLine("\n\t\t\t PLEASE ETNER YOUR NAME");
		name=Console.ReadLine();
	}
		public void getvalue()
	{
		Console.WriteLine("\n\t\t\t HELLO {0}",name);
		name=Console.ReadLine();
	}
}
class mainclass
{
	static void Main(String[]args)
	{
		student stu1=new student();
		for(int i=1;i<=10;i++)
		{
		stu1.setvalue();
		stu1.getvalue();
		}
}
}