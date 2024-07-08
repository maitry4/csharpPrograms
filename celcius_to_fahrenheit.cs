using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _404celciusToFar
{
    class Program
    {
        static void Main(string[] args)
        {
            double celcius, fahrenheit;
            Console.WriteLine("Enter temperature in celcius: ");
            celcius = double.Parse(Console.ReadLine());
            fahrenheit = (celcius * (9 / 5)) + 32;
            Console.WriteLine("Fahrenheit: " + fahrenheit);
            Console.ReadLine();
        }
    }
}
