using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter a word");
            var input = Console.ReadLine();
            var output = "";

            foreach (var c in input)
                output = c + output;

            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
