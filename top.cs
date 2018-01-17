using System;
class Interchange
{
int Top_score;
int New_score;
int Temp;
void Swap()
{
Top_score=5;
New_score=10;
Temp=Top_score;
Top_score=New_score;
New_score=Temp;
}
void Display()
{
Console.WriteLine("The new value of top score is:");
Console.WriteLine(Top_score);
Console.WriteLine("The old value of top score was:");
Console.WriteLine(New_score);
}
static void Main()
{
Interchange I1=new Interchange();
I1.Swap();
I1.Display();
Console.ReadLine();
}
}