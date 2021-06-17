using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Repeat
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> repeatStrings = Enumerable.Repeat("Welcome to DOT NET Tutorials", 10);
            foreach (String str in repeatStrings)
            {
                Console.WriteLine(str);
            }
            Console.ReadKey();
        }
    }
}
