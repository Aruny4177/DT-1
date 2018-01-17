using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] score=newint[5]{2,4,6,8,10};
            int i;
            for (i=0;i<5;i++)
            {
                ++score[i];
                Console.WriteLine(score[i]);
            }
        }
    }
}
