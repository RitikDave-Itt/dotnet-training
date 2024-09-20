using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Program
{
    class Problem
    {
         public void Problem1()
        {
            string sentence = Console.ReadLine();

            

            string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int wordCount = words.Length;
            string[] reversedWords = new string[wordCount];
            for (int i = 0; i < wordCount; i++)
            {
                char[] wordArray = words[i].ToCharArray();
                Array.Reverse(wordArray);

                reversedWords[i] = new string(wordArray);
            }
            Console.WriteLine($"Word count: {wordCount}");
            Console.WriteLine("Reversed words:");
            foreach (string reversedWord in reversedWords)
            {
                Console.WriteLine(reversedWord);
            }

            Console.Read();


        }

     
    }
    internal class Program
    {
        class Sulutions
        {

        }
        static void Main(string[] args)
        {
            Problem problem = new Problem();
            problem.Problem1();
        }
    }
}
