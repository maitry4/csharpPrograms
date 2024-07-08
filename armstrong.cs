using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _404Armstrong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, r, sum = 0, temp;
            Console.WriteLine("Enter the Number= ");
            n = int.Parse(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                r = n % 10; //Get the last digit from the number.
                sum = sum + (r * r * r); //add the cube of this number to the cube of previous numbers.
                n = n / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("Armstrong Number.");
            }

            else
            {
                Console.WriteLine("Not Armstrong Number.");
            }
            Console.ReadLine();
    }
    }
}
