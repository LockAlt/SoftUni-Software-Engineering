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

            int nights = days - 1;

            double priceForStay = 0;

            if (room == "room for one person")
            {
                priceForStay = nights * 18.00;
            }
            else if (room == "apartment")
            {
                priceForStay = nights * 25.00;
                if (days<10)
                {
                    priceForStay = priceForStay - (priceForStay * 30 / 100);   
                }
                else if (days>=10 && days<=15)
                {
                    priceForStay = priceForStay - (priceForStay * 35 / 100);
                }
                else
                {
                    priceForStay = priceForStay - (priceForStay * 50 / 100);
                }
            }
            else
            {
                priceForStay = nights * 35.00;
                if (days < 10)
                {
                    priceForStay = priceForStay - (priceForStay * 10 / 100);
                }
                else if (days >= 10 && days <= 15)
                {
                    priceForStay = priceForStay - (priceForStay * 15 / 100);
                }
                else
                {
                    priceForStay = priceForStay - (priceForStay * 20 / 100);
                }
            }
            if (rating== "positive")
            {
                priceForStay = priceForStay + (priceForStay * 25 / 100);
            }
            else
            {
                priceForStay = priceForStay - (priceForStay * 10 / 100);
            }
            
            Console.WriteLine($"{priceForStay:f2}");
        }
    }
}