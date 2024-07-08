using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _404switch_prac
{
    class Program
    {
        static void Main(string[] args)
        {
            //switch case(good morning, afternoon and evening)
            int hour;
            Console.WriteLine("What hour of the day it is? (24-hour Format): ");
            hour = int.Parse(Console.ReadLine());

            if (hour < 12)
            {
                Console.WriteLine("Good Morning!");
            }
            else if(12 <= hour && hour < 17)
            {
                Console.WriteLine("Good AfterNoon!");
            }
            else
            {
                Console.WriteLine("Good Evening!");
            }
            Console.ReadLine();
        }
    }
}
