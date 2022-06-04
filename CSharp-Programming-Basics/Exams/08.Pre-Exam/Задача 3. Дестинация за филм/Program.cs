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

            if (destination == "Dubai")
            {
                if (season == "Winter")
                {
                    moneyNeeded = days * 45000;
                }
                else
                {
                    moneyNeeded = days * 40000;
                }
               moneyNeeded-= moneyNeeded * 30 / 100;  //moneyNeeded = moneyNeeded - moneyNeeded * 30 / 100;  
            }
            else if (destination == "Sofia")
            {
                if (season == "Winter")
                {
                    moneyNeeded = days * 17000 ;
                }
                else
                {
                    moneyNeeded = days * 12500 ;
                }
                moneyNeeded += moneyNeeded * 25 / 100; //moneyNeeded = moneyNeeded + moneyNeeded * 25 / 100;  
            }
            else //(destination == "London")
            {
                if (season == "Winter")
                {
                    moneyNeeded = days * 24000;
                }
                else
                {
                    moneyNeeded = days * 20250;
                }

            }

            if (budget>= moneyNeeded)
            {
                Console.WriteLine($"The budget for the movie is enough! We have {budget-moneyNeeded:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"The director needs {moneyNeeded-budget:f2} leva more!");
            }


        }
    }
}