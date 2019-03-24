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
            Console.WriteLine("Key count:");
            var input = "Hello world";
            var charDictionary = new Dictionary<char, int>();

            foreach (var c in input)
            {
                if (c == ' ') return;

                if (charDictionary.ContainsKey(c))
                    charDictionary[c]++;
                else
                    charDictionary.Add(c, 1);                
            }

            foreach (var key in charDictionary)
                Console.WriteLine(key.Key + " " + key.Value);            
        }
    }
}
