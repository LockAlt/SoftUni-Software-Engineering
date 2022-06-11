using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budgetForFilm = double.Parse(Console.ReadLine());    
            int numberStatisti = int.Parse(Console.ReadLine());   
            double priceClothesForOneStatist = double.Parse(Console.ReadLine());

            double filmDecorPrice = budgetForFilm * 10 / 100.0;
            double priceForAllClothes = numberStatisti * priceClothesForOneStatist; 
            if (numberStatisti > 150 )
            {
                priceForAllClothes = priceForAllClothes - (priceForAllClothes * 10 / 100.0);
            }

            double totalSum = filmDecorPrice + priceForAllClothes;
            double leftMoney = budgetForFilm - totalSum;

            if( filmDecorPrice + priceForAllClothes > budgetForFilm)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(leftMoney) :F2} leva more."); // Za da e polojitelno chislo
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {leftMoney:F2} leva left.");
            }

        }
    }
}