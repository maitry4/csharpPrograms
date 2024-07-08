using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _404areaofCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            double r;
            double area;
            Console.WriteLine("Enter radius: ");
            r = double.Parse(Console.ReadLine());
            area = r * r * Math.PI;
            Console.WriteLine("Area of Circle is: " + area);
            Console.ReadLine();
        }
    }
}
