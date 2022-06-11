using System;

namespace SumOfOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int oddNumberCountLimit = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int number = 1; number <= oddNumberCountLimit; number++)
            {
                if (number % 2 != 0)
                {
                    Console.WriteLine(number);
                    sum += number;
                }
                else
                {
                    oddNumberCountLimit++;
                }
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
