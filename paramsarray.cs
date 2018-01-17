using System;
namespace ParamArrays{
public class ParamExample {
public int Adding_ArrayElement(params int[] List){
int Total = 0;
foreach ( int I in List )
{
Total += I;
}
return Total;
}
}
class Tester{
static void Main(string[] args){
ParamExample Param_Exam = new ParamExample();
int Total = Param_Exam.Adding_ArrayElement(1,2,3,4,5,6,7,6,7);
Console.WriteLine( "The Result is {0}",Total );
}
}
}

