using System;
class vowelConsotant
{
	static void Main (String [] args)
	{
		char Alphabet;
		
		Console.WriteLine("Enter the Alphabet");
		Alphabet = Convert.ToChar(Console.ReadLine());
		switch(Alphabet)
		{
			case 'a':
			break;
			case 'e':
			break;
			case 'i':
			break
			case 'o':
			break;
			case 'u':	

		Console.WriteLine("The Alphabet you have entered is vowel");
		break;
		default:
		Console.WriteLine("The Alphabet you have entered is Consontant");
		break;
		}
		Console.ReadLine();
	}
	}