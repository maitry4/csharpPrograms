using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _404Largest_of_three
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 50;
            int b = 120;
            int c = 30;
            if(a>b)
            {
                if (a > c)
                {
                    Console.WriteLine("a is Largest.");
                }
                else
                {
                    Console.WriteLine("c is Largest.");
                }
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine("b is Largest.");
                }
                else
                {
                    Console.WriteLine("c is Largest.");
                }
            }
            Console.ReadLine();
        }
    }
}
