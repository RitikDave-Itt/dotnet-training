using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem3
{

    internal class Program
    {
        static bool IsPalindrome(int number)
        {
            string str = number.ToString();
            char[] reversed = str.Reverse().ToArray();
            return str == new string(reversed);
        }

        static int CountPalindromes(List<int> numbers)
        {
            return numbers.Count(IsPalindrome);
        }

        static int FindHighestPalindrome(List<int> numbers)
        {
            var palindromes = numbers.Where(IsPalindrome).ToList();
            return palindromes.Any() ? palindromes.Max() : int.MinValue; 
        }

        
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 121, 12, 21, 345, 543, 567, 765, 232, 999 };

            int totalPalindromes = CountPalindromes(numbers);
            int highestPalindrome = FindHighestPalindrome(numbers);

            Console.WriteLine("Total number of palindromes: " + totalPalindromes);
            Console.WriteLine("Highest palindrome: " + (highestPalindrome == int.MinValue ? "None" : highestPalindrome.ToString()));
            Console.Read();
        }
    }
}
