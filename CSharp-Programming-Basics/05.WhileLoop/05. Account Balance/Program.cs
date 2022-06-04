using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); // "300" string !

            double account = 0;

            while (input!="NoMoreMoney")
            {
                double amount = double.Parse(input); // 300.0 double ! тук вече става double и може да правим изчисления като това отдолу с тези числа
                if (amount <0)
                {
                    Console.WriteLine("Invalid operation!");
                    break; // Изписва се отгоре  "Invalid operation!" и излиза от цикъла и директно се изписва ето това което е извън цикъла Console.WriteLine($"Total: {account:f2}");
                }
                account += amount;

                Console.WriteLine($"Increase: {amount:f2}");

                input = Console.ReadLine(); // това тук пак е string  // ако го нямаше това щеше да има безкраел лооп // това служи за въвеждане на нова стойност на input когато стигне дотук
            }
            
            Console.WriteLine($"Total: {account:f2}");
        }
    }
}