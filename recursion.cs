using System;
class Number
    {
        public int factorial(int n)
        {
            int result;
            if (n == 1)
                return 1;
            else 
            { 
                result = factorial(n - 1) * n; 
                return result;
            }
	}  
    static void Main(string[] args)
        {
            Number obj = new Number();
            Console.WriteLine("Factorial of 4   		is " + obj.factorial(4));
        }
    }

