using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int time = first + second + third; // в секунди

            int min = time / 60; // 150/60 => 2 ( 2 пъти се съдържа )
            int sec = time % 60; // 150 % 60 => 2 и (30) остатък
            //ако сек. < 10 => $("{min}:0{sec}")
            if (sec<10)
            {
                Console.WriteLine($"{min}:0{sec}");
            }
            else
            {
                Console.WriteLine($"{min}:{sec}");
            }
        }
    }
}