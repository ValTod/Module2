using System;

namespace PoisitiveNegativeNull
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            string word = Sign(x);
            PrintSign(word, x);

        }
        static void PrintSign(string s, int number)
        {
            Console.WriteLine($"the sign of the number {number} is: {s}");
        }

        static string Sign(int number)
        {
            string x = "";
            if (number > 0)
                x= "+";
            else if (number < 0)
                x= "-";
            else
                x="0";
            return x;
        }

    }
}
