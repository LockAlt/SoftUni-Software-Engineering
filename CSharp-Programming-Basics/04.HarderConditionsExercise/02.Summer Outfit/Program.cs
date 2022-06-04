using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();

            string outfit = ""; // Tova sa prazni promenlivi za da ni e po-lesno
            string shoes = ""; // Tova sa prazni promenlivi za da ni e po-lesno

            switch (time)
            {
                case "Morning":
                    if (degrees <= 18) // Zashtoto znaem che nqma da se vuvedat 10 ili po-malko ot 10 ot konzolata ->//•	Градусите - цяло число в интервала [10…42]
                    {
                        outfit = "Sweatshirt";
                        shoes = "Sneakers";
                    }
                    else if (degrees <= 24) // Nqma smisul da slagame degrees >18 && degrees <= 24 zashtoto ako sa pod 18 shte vleznat gore
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else // (degrees >=25)
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                    }
                    break;
                case "Afternoon":
                    if (degrees <= 18)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (degrees <= 24)
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                    }
                    else
                    {
                        outfit = "Swim Suit";
                        shoes = "Barefoot";
                    }
                    break;
                default:
                    if (degrees <= 18)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (degrees <= 24)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    break;
            }
            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
        }
    }
}