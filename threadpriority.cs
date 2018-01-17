	using System;
	using System.Threading;
 
	class ThreadSchedule 
	{
    public static void ChildThread1()
    {
        Console.WriteLine("Child thread 1 started");
        Console.WriteLine("Child thread - counting from 1 to 10");
		 for (int T = 1; T < 11; T++) 
        {
            for (int Cnt = 0; Cnt < 100; Cnt++)
       {    
          Console.Write(".");
        // Code to imitate work being done
        }
         Console.Write("{0}", T);
        }
       Console.WriteLine("Child thread 1 finished");
 		}	
    public static void ChildThread2()
    {
        Console.WriteLine("Child thread 2 started");
        Console.WriteLine("Child thread - counting from 11 to 20");
        for (int T = 11; T < 20; T++) 
        {
for (int Cnt = 0; Cnt < 100; Cnt++) 
            {    
                Console.Write(".");
                // Code to imitate work being done
            }
            Console.Write("{0}", T);
        }
 	   Console.WriteLine("Child thread 2 finished");
    }
 public static void Main()
 {    
 ThreadStart Child1 = new ThreadStart(ChildThread1);
 ThreadStart Child2 = new ThreadStart(ChildThread2);
 Console.WriteLine("Main - Creating Child threads");
 
	Thread Thread1 = new Thread(Child1);
	Thread Thread2 = new Thread(Child2);
 
   Thread1.Priority = ThreadPriority.Highest;
   Thread2.Priority = ThreadPriority.Lowest;
    Thread1.Start();
   Thread2.Start();
   }
}
