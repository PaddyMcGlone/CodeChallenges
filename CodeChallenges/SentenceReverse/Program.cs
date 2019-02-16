using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentenceReverse
{
    class Program
    {
        // Original sentence : Hello world from console
        // New sentence: console from world Hello

        static void Main(string[] args)
        {
            const string input = "Hello world from console";
            var output = "";
            
            var myArray = input.Split(' ').ToArray().Reverse();

            foreach (var word in myArray)
                output += string.Format("{0} ", word);

            Console.WriteLine(output);
        }
    }
}
