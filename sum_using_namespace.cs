using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace getNum1
{
    public class SampleClass
    {
        public static int input()
        {
            int a;
            Console.WriteLine("Enter the value in a:");
            a = Convert.ToInt32(Console.ReadLine());
            return a;
        }
    }
}
namespace getNum2
{
    public class SampleClass
    {
        public static int input()
        {
            int b;
            Console.WriteLine("Enter the value in a:");
            b = Convert.ToInt32(Console.ReadLine());
            return b;
        }
    }
}
namespace _404SumUsingNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum, x, y;
            x = getNum1.SampleClass.input();
            y = getNum2.SampleClass.input();
            sum = x + y;
            Console.WriteLine(sum);
            Console.ReadLine();

        }
    }
}
