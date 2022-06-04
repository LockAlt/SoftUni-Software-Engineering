using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string season = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double moneyNeeded = 0;

            if (season == "Winter")
            {
                if (destination=="Dubai")
                {
                    moneyNeeded = days * 45000;
                }
                else if (destination=="Sofia")
                {
                    moneyNeeded = days * 17000;
                }
                else
                {
                    moneyNeeded = days * 24000;
                }
            }
            else
            {
                if (destination == "Dubai")
                {
                    moneyNeeded = days * 40000;
                }
                else if (destination == "Sofia")
                {
                    moneyNeeded = days * 12500;
                }
                else
                {
                    moneyNeeded = days * 20250;
                }
            }
            if (destination == "Dubai")
            {
                moneyNeeded -= moneyNeeded * 30 / 100;
            }
            else if (destination == "Sofia") 
            {
                moneyNeeded += moneyNeeded * 25 / 100;
            }

            if (budget >= moneyNeeded)
            {
                Console.WriteLine($"The budget for the movie is enough! We have {budget - moneyNeeded:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"The director needs {moneyNeeded - budget:f2} leva more!");
            }
        }
    }
}