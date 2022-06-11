using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 10; i++)
            //{
            //    int sum = i + 5; // Когато това е в цикъла то не съществува извън цикъла и следователно не може да го изкараме така както е на console write
            //    Console.WriteLine(i);

            //}
            //Console.WriteLine($"This is sum {sum}");

            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum = sum + (i + 5);
                Console.WriteLine(i); // Слагаме  BREAK POINT тук и когато натисенм F5 виждаме при какви стойности и кога принти i 

            }
            Console.WriteLine($"this is sum {sum}");

            //ВИЖ РАЗЛИКИТЕ В СТОЙНОСТТА НА SUM НА ГОРНОТО И ДОЛНОТО

            //int sum = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    sum = i + 5;
            //    Console.WriteLine(i);

            //}
            //Console.WriteLine($"This is sum {sum}");

        }
    }
}