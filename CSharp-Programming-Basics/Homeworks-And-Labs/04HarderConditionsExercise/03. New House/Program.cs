using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeFlower = Console.ReadLine();
            int numFlower = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());


            double price = 0.0;
            if (typeFlower == "Roses")
            {
                price = numFlower * 5.00;
                if (numFlower > 80)
                {
                    price = price - (price * 0.10);  // Vadim 10% otsutpka
                }
            }
            else if (typeFlower == "Dahlias")
            {
                price = numFlower * 3.80;
                if (numFlower > 90)
                {
                    price = price - (price * 0.15); //  price -= price * 0.15;
                }
            }
            else if (typeFlower == "Tulips")
            {
                price = numFlower * 2.80;
                if (numFlower > 80)
                {
                    price = price - (price * 0.15);
                }
            }
            else if (typeFlower == "Narcissus")
            {
                price = numFlower * 3.00; // Tuk e dobre da slojim 3.00 vmesto samo 3 
                if (numFlower < 120)
                {
                    price = price + (price * 0.15);
                }
            }
            else if (typeFlower == "Gladiolus")
            {
                price = numFlower * 2.50;
                if (numFlower < 80)
                {
                    price = price + (price * 0.20); //  price += price * 0.20;
                }

            }
            if (budget >= price)
            {
                Console.WriteLine($"Hey, you have a great garden with {numFlower} {typeFlower} and {budget - price:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {price - budget :f2} leva more.");
            }
        }
    }
}