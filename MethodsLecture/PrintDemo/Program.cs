using System;

namespace PrintDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Receipt:");
            PrintHeader();
            PrintValues(x);
            PrintArrows();
            double d = 348*PrintDoubles(x);
            PrintHeader();
            PrintValues((int)d);

        }

        static void PrintHeader()
        {
            Console.WriteLine("----------");
        }

        static void PrintArrows ()
        {
            Console.WriteLine("-> -> -> ->");
        }
        static void PrintValues(int n)
        {
            Console.WriteLine($"the value is: {n}");
        }
        static double PrintDoubles(int n) => n / 125;
        //{
        //    double d = n / 125;
        //    return d;
        //}        
    }
}
