using System;

namespace StringReverse
{
    class Program
    {
        static void Main(string[] args)
        {

            // Attempt 1:
            Console.WriteLine("Please enter a string to reverse!");
            var inputString = Console.ReadLine();
            var myArray = inputString.ToCharArray();

            for (int i = 0, j = inputString.Length-1; i < j; i++, j--)
            {
                myArray[i] = inputString[j];
                myArray[j] = inputString[i];
            }
            Console.WriteLine($"Your string: {new string(myArray)}");


            // Attempt 2:
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
