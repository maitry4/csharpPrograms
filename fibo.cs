using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _404Fibonacci_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fibonacci sequence
            int a = 0, b = 1, c,n;

            Console.WriteLine("Enter the length of fibo: ");
            n = int.Parse(Console.ReadLine());

            //first 2
            Console.WriteLine(a);
            Console.WriteLine(b);
            for(int i =2; i<n; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }
            Console.ReadLine();
        }
    }
}
