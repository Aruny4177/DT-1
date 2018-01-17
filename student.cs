using System;
class Student_Detail
{
	public static void Main(string[] args)
		{
		string Stud_Name;
		int stud_age;
		Console.WriteLine("Enter your name");
		Stud_Name = Console.ReadLine();
		Console.WriteLine("Enter your age");
		stud_age = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("The Name and Age is : {0}, {1}",Stud_Name,stud_age);
		}
}	