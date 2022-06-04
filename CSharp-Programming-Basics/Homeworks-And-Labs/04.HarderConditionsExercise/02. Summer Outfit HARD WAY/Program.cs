using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();

            if (time == "Morning")
            {
                if (degrees <= 18) // Zashtoto znaem che nqma da se vuvedat 10 ili po-malko ot 10 ot konzolata ->//•	Градусите - цяло число в интервала [10…42]
                {
                    string outfit = "Sweatshirt";
                    string shoes = "Sneakers";
                }
                else if (degrees <= 24) // Nqma smisul da slagame degrees >18 && degrees <= 24 zashtoto ako sa pod 18 shte vleznat gore
                {
                    string outfit = "Shirt";
                    string shoes = "Moccasins";
                }
                else // (degrees >=25)
                {
                   string outfit = "T-Shirt";
                   string shoes = "Sandals";
                }
            }
            else if (time == "Afternoon")
            {
                if (degrees <= 18)
                {
                    string outfit = "Shirt";
                    string shoes = "Moccasins";
                }
                else if (degrees <= 24)
                {
                   string outfit = "T-Shirt";
                   string shoes = "Sandals";
                }
                else
                {
                   string outfit = "Swim Suit";
                   string shoes = "Barefoot";
                }
            }
            else // (time == "Evening")
            {
                if (degrees <= 18)
                {
                    string outfit = "Shirt";
                    string shoes = "Moccasins";
                }
                else if (degrees <= 24)
                {
                    string outfit = "Shirt";
                    string shoes = "Moccasins";
                }
                else
                {
                    string outfit = "Shirt";
                    string shoes = "Moccasins";
                }
            }
            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}."); // MNOGO VAJNOOO !!!!! // KOGATO NQMAME STOINOSTITE OUTFIT I SHOES PREDI IFOVETE TE NE MOGAT DA SE OTPECHATAT ZASHTOTO OUTFIT I SHOES GI IMA SAMO V BLOKA OT KOD NA IF,ELSE IF, ELSE I NE MOGA DA SE IZPISHAT
        }
    }
}