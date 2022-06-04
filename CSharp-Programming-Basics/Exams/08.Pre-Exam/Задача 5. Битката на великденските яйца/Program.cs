using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2 променливи които пазят броя яйца на първия и втория играч
            //first, second
            int firstEggs = int.Parse(Console.ReadLine()); // броят яйца на играч 1
            int secondEggs = int.Parse(Console.ReadLine());// броят яйца на играч 2

            // променлива която пази входът който получаваме  (input)
            // вариантите за вход са 3 : one , two, End of battle
            string input = Console.ReadLine();

            // цикъл , който ще се изпълнява докато не получим input == "End of battle"
            // при всяко изпълнение на цикъла имаме два варианта 
            // 1.
            // => input = "one" => яйцата на втория играч намаляват с единица => second--;
            // => проверяваме дали яйцата на second == 0 и ако са станали 0 отпечатваме изхода и break;
            //Ако първият играч остане без яйца:
            //•	"Player two is out of eggs. Player one has {брой останали яйца на втория играч} eggs left."

            //2.
            //Ако вторият играч остане без яйца:
            // => input = "two" => яйцата на първия играч намаляват с единица => first--;
            // => проверяваме дали яйцата на first == 0 и ако са станали 0 отпечатваме изхода и break;
            //•	"Player one is out of eggs. Player two has {брой останали яйца на първия играч} eggs left."

            //цикълът ни спира ако яйцата на първия стана == 0 или яйцата на втория станат == 0

            //при всяко завъртане на цикъла четем нов input 
            while (input != "End of battle")
            {
                if (input == "one")
                {
                    secondEggs--;
                    if (secondEggs==0)
                    {
                        Console.WriteLine($"Player two is out of eggs. Player one has {firstEggs} eggs left.");
                        break;
                    }
                }
                else // input == "two"
                {
                    firstEggs--;
                    if (firstEggs==0)
                    {
                        Console.WriteLine($"Player one is out of eggs. Player two has {secondEggs} eggs left.");
                        break;
                    }
                }

                input = Console.ReadLine();
            }
            // Ako яйцата на first >0 и яйцата на second>0 отпечатваме 
            //При команда "End of battle" да се отпечатат два реда:
            //•	"Player one has {брой останали яйца на първия играч} eggs left."
            //•	"Player two has {брой останали яйца на втория играч} eggs left."
           
            if (firstEggs>0 && secondEggs>0) // може и така  if (input =="End of battle")
            {
                Console.WriteLine($"Player one has {firstEggs} eggs left.");
                Console.WriteLine($"Player two has {secondEggs} eggs left.");
            }



        }
    }
}