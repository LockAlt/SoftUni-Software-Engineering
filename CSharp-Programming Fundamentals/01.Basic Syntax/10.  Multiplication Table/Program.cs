using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= 10; i++) // Все едно целият този цикъл е   for (int times = 1; times <= 10; times++) буквално колко пъти да се повтори едно нещо !
            {
                int product = number * i;
                Console.WriteLine($"{number} X {i} = {product}");
            }
        }
    }
}