using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int number = int.Parse(Console.ReadLine());
                if (number%2!=0)
                {
                    Console.WriteLine("Please write an even number.");
                }
                else
                {
                    Console.WriteLine($"The number is: {Math.Abs(number)}"); // абсолютната стойност на числото ( винаги положително )
                    break; // Ако го нямаше този break while цикъла щеше да е вечен защото е while (true), а то винаги е true
                }
            }
        }
    }
}