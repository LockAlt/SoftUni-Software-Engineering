using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //  Това е съшата задача като 6-ста само че е с друго условие ( на Влади е ) 
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());


            int d1;
            int d2;
            int d3;
            int d4;

            for (int num = num1; num < num2; num++)
            {
                d4 = num % 10;
                d3 = num / 10 % 10;
                d2 = num / 100 % 10;
                d1 = num / 1000;

                if (d1 % 2 != 0 && d2 % 2 != 0 && d3 % 2 != 0 && d4 % 2 != 0)
                {
                    Console.Write($"{num} ");
                }
            }
        }
    }
}