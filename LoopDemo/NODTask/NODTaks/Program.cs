using System;

namespace modu_2_
{
    class LoopProgram
    {
        static void Main()
        {
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());

            //while (a != b)
            //{
            //    if (a > b)
            //        a -= b;
            //    else
            //        b -= a;

            //}
            //int nod = a;
            //Console.WriteLine("nod = " + nod);

            Console.WriteLine("Please enter the number:");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            while (number != 0)
            {
                int digit = number % 10;
                sum += digit;
                number /= 10;
            }
            Console.WriteLine($"The sum of the digits of the number: {sum}");
        }
    }
}