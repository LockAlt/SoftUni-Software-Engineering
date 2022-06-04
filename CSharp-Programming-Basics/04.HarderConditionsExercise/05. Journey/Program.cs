using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double price = 0;
            string destination = "";
            string typeOfVacation = "";

            if (budget <= 100)
            {
                destination = "Bulgaria"; // string destination = "Bulgaria"; ako go nqmashe ot gore
                if (season == "summer")
                {
                    typeOfVacation = "Camp"; // string typeOfVac = "Camp"; Ako go nqmah tova ot gore i taka trqbvashe da go pisha na vseki red
                    price = budget * 0.30; // Ako go nqmashe otgore double price = 0; shtqh da napravq vuv vseki if string price = budget * 0.30;
                }
                else
                {
                    typeOfVacation = "Hotel";
                    price = budget * 0.70;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    typeOfVacation = "Camp";
                    price = budget * 0.40;
                }
                else
                {
                    typeOfVacation = "Hotel";
                    price = budget * 0.80;
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                typeOfVacation = "Hotel";
                price = budget * 90 / 100;
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{typeOfVacation} - {price:F2}");
        }
    }
}