using System;
	namespace VirtualFunction 
	{
    class Animal
    {
        public virtual void FoodHabits()
        {
			Console.WriteLine("Animals has different 				   food habits");
        }
    }        
	class Carnivorous : Animal
    {
        public override void FoodHabits()
        {
          Console.WriteLine("The Carnivorous animals 	eat only meat");
        }
    } 
 	class Herbivorous : Animal
    {
        public override void FoodHabits()
        { 
	 Console.WriteLine("The Herbivourous animals eat only plants");
		}
	}
	class Implement
	{
		public void callFunction(Animal Cr)
		{
            Cr.FoodHabits();
        }
    }
	class ClassMain 
    {
        public static void Main()
        {
			Implement Imp = new Implement();
			Carnivorous cn = new Carnivorous();
			Herbivorous hb = new Herbivorous();
			Imp.callFunction(cn);
			Imp.callFunction(hb);
			Console.ReadLine();
        }
     }
	}

