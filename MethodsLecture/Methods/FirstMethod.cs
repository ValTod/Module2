using System;
using System.Collections.Generic;
using System.Linq;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            numbers.Sort();

            List<int> staticList = new List<int>{ 1, 2, 3, 4 };
            List<string> stringList = new List<string>{ "a", "b", "c", "d"};

            Console.WriteLine("first call:");
            Print(numbers);
            Console.WriteLine("second call:");
            Print(staticList);

            //Print(stringList);

            Print(numbers);
            
        }

        static void Print(List<int> n)
        {
            Console.WriteLine(string.Join("<=>", n));
        }
    }
}
 