using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string rating = Console.ReadLine();

            double price = 0;
            int nights = days - 1;
            if (room == "room for one person")
            {
                price = 18.00;
            }
            else if (room == "apartment")
            {
                price = 25.00;
                if (days < 10)
                {
                    price = price - (price * 0.30);
                }
                else if (days >= 10 && days <= 15)
                {
                    price = price - (price * 0.35);
                }
                else
                {
                    price = price - (price * 0.50);
                }
            }
            else if (room == "president apartment")
            {
                price = 35.00;
                if (days < 10)
                {
                    price = price - (price * 0.10);
                }
                else if (days >= 10 && days <= 15)
                {
                    price = price - (price * 0.15);
                }
                else
                {
                    price = price - (price * 0.20);
                }
            }

            if (rating == "positive")
            {
                price = price + (price * 0.25);
            }
            else
            {
                price = price - (price * 0.10);
            }

            double finalPrice = nights * price; // !!!
            Console.WriteLine($"{finalPrice:F2}");
        }
    }
}