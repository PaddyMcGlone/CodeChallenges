using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        public static bool CalculatePalindrome(string input)
        {
            for (int i = 0, j = input.Length - 1; i < j; i++, j--)
            {
                if (input[i] != input[j])               
                    return false;                
            }
            return true;
        }

        public static void AskQuestionShowResult()
        {
            Console.WriteLine("Please enter a word");
            var input = Console.ReadLine();
            var result = CalculatePalindrome(input);

            Console.WriteLine($"Is this a Palindrome? : {result.ToString()}");
        }

        public static bool ReTry;

        static void Main()
        {
            do
            {
                AskQuestionShowResult();

                Console.WriteLine("Would you like to try again? [Y/N]");                
                ReTry = Console.ReadKey().Key.ToString() == "Y" ? true : false;                
            } while (ReTry);
        }
    }
}
