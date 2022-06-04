using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyPerDay = double.Parse(Console.ReadLine());
            double moneyGainPerDay = double.Parse(Console.ReadLine());
            double costForAllPeriod = double.Parse(Console.ReadLine());
            double priceForGift = double.Parse(Console.ReadLine());

            int days = 5;
            double savedMoneyForPocket = 0;
            double earnedMoney = 0;
            double totalSavedMoney = 0;



            savedMoneyForPocket = days * moneyPerDay;
            earnedMoney = days * moneyGainPerDay;
            totalSavedMoney = savedMoneyForPocket + earnedMoney;
            totalSavedMoney = totalSavedMoney - costForAllPeriod;

            if (totalSavedMoney>priceForGift)
            {
                Console.WriteLine($"Profit: {totalSavedMoney:f2} BGN, the gift has been purchased.");
            }
            else
            {
                Console.WriteLine($"Insufficient money: {priceForGift - totalSavedMoney:f2} BGN.");
            }
        }
    }
}