using System;
using System.IO;
usingSystem.Threading;
namespace Game
{
public class Typometer
    {

public void StartGame()
        {
            String str;
str= "The Cheater Cheats the Cheating Code";
            String str1;
            str1 = "She Sell Sea Shell On The Sea Shore!";
Console.WriteLine("Level 1: \n{0}", str);
            String userVal= Console.ReadLine();
if(userVal==str)
              {
Console.WriteLine("\nYou WON! Welcome to Level 2! \n");
	Console.WriteLine("Level 2: \n{0}",str1);
                String userVal1= Console.ReadLine();
if (userVal1 == str1)
                   {
Console.WriteLine("\nYou WON! Game Over! \n");
	System.Environment.Exit(0);
                   }
else
                   {
		Console.WriteLine("\nThe strings do notmatch..Game Over! \n");
                   }
        }
else
			{
		Console.WriteLine("\nThe strings do not match..Try Again! \n");
			StartGame();
	}
	}
    }
class Game
    {
static void Main(string[] args)
        {
Console.Clear();
Console.WriteLine("This game has two levels\n");
		Console.WriteLine("In each level you have to type a 			   string\n");

		Console.WriteLine("You have 25 seconds to complete the game \n");
Typometerobj = new Typometer();
              {

		Thread t = new Thread(new ThreadStart(obj.StartGame));
t.Start();//Starting the new thread
Thread.Sleep(25000);/*Making the Main thread sleep for 25 Seconds*/
try
		            {
		t.Abort();
Console.WriteLine("\n\nSorry You lose! The Time is Over!");
	                   }//Killing the new thread
catch (ThreadAbortException e) 
			     {
		Console.WriteLine(e.Message); }
	     }
	Console.ReadLine();
		}
		  }
	      }


