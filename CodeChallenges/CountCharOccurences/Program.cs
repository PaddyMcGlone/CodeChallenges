using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountCharOccurences
{
    class Program
    {
        // Count the number of times a char appears within a sentence.

        static void Main(string[] args)
        {
            var input = "Hello world";

            int total = 0;

            foreach (var c in input)
            {
                if (c == 'o') total++;
            }

            Console.WriteLine("The char 'o' appears : {0} times", total);
            Console.ReadKey();
        }
    }
}
