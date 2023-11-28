using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySqrt
{
    internal class Program
    {
        public static double CalculateSqrt(double target)
        {
            double x = 1;
            double oldx;
            do
            {
                oldx = x;
                x = (x + target / x) / 2;
            }
            while (oldx != x);
            return x;
        }
        static void Main()
        {
            double target = 2023;
            double result = CalculateSqrt(target);
            Console.WriteLine(result);
            Console.WriteLine(result * result);
            Console.ReadLine();
        }
    }
}
