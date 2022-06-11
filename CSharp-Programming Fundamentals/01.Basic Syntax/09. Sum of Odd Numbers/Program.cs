using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int oddNumbersCount = int.Parse(Console.ReadLine());
            int sum = 0;
            int currentNumber = 0;
            
            for (int i = 1; i <= oddNumbersCount; i++)
            {    
                currentNumber = 2 * i - 1;
                Console.WriteLine(currentNumber);
                sum += currentNumber;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}