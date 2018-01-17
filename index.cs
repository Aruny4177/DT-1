using System;
using System.Collections;

class myIndexer
{
   private string []name = new string[5];
   public string this [int index]
      {
     get
     {
       return name[index]; 
}
     set
     {
       name[index] = value;
     }
   }
}

class MyMain
{
  public static void Main()
  {
        myIndexer ind = new myIndexer();
     ind[0] = "John";	//calls the setter method
     ind[1] = "Sam";
     ind[2] = "Maria";
        ind[3] = "Paul"; 
   
   ind[4] = "Rachel";
   Console.WriteLine("{0},{1},{3},{2},{4}",ind[4],ind[1],ind[2],ind[3],ind[0]);
			//calls the getter method
     }
}

