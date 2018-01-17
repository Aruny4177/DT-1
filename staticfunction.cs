using System;
public class StaticExample 
{
    public static int s;
    public void count()
    {
        s++;
    }
    public static int display()
    {
        return s;
    }
 }
    class Static
    {
      static int Main(string[] args)
     {
        StaticExample s = new StaticExample();
        s.count();
        s.count();
        s.count();
        Console.WriteLine("The value of variable 		is {0}",StaticExample.display());
        return 0;
     }
    }
