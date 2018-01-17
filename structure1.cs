using System;
namespace Bills
{
    public struct Student_Details
    {
        public string Name;
        public string Course_Enrolled;
        public int Student_Id;
        public int Registeration_Id;
    };
    class TestStructure
    {
       
        public static void Main(string[] args)
        {
            Student_Details details = new Student_Details();
            Console.WriteLine("Enter your Name:");
            details.Name = Console.ReadLine();
            Console.WriteLine("Enter the Course in which you want to enroll:");
            details.Course_Enrolled = Console.ReadLine();
            Console.WriteLine("Enter the student ID assigned to you in the batch:");
            details.Student_Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the registeration ID assigned to you in the batch:");
            details.Registeration_Id = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Student name is:" + details.Name);
            Console.WriteLine(details.Name + " enrolled for the " + details.Course_Enrolled + " course.");
            Console.WriteLine(details.Name + " Student ID is:" + details.Student_Id);
            Console.WriteLine(details.Name + " Registeration ID is:" + details.Registeration_Id);
        }
    }
}

