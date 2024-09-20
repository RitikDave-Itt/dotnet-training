using System;

namespace MyConsoleApp
{
    class Pattern
    {
        public void NumbersTriangle(int n)
        {
            for (int i = n; i >= 0; i--) {
                for (int j = 1; j < i+1; j++)
                {
                    Console.Write("%d",j);
                    
                }
                Console.WriteLine("");
            }

        }
    }
    class Program

    {
        static void Main(string[] args)
        {
            Pattern pattern = new Pattern();
            pattern.NumbersTriangle(5);
            Console.ResetColor();
            Console.Read();
        }
    }
}
