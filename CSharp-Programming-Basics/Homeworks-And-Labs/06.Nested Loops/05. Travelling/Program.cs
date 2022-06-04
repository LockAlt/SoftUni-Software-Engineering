using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ще използваме while защотото имаме string и докато не получим командата "End"  и не знаем на колко дестинации ще отиде
            // И вътре ще ползваме още един while цикъл защото не знаем колко пъти ще спестява ( не знаем колко вноски ще направи ) докато при for имаме точно определен брой път повторение и тн.


            string destination = Console.ReadLine();
            double minBudget = 0;
            double savings = 0;

            while (destination!= "End")
            {
                // double savings = 0;
                minBudget = double.Parse(Console.ReadLine());
                while (minBudget > savings)
                {
                    savings+= double.Parse(Console.ReadLine());
                }
                Console.WriteLine($"Going to {destination}!");
                 savings = 0; // Или го добавяме това така или слагаме   double savings = 0; горе , за да може след като прочете нова дестинация нали се връща отгоре на цикъла да провери дали destination!= "End" и като влезе в цикъла да стават savings = 0  
                destination = Console.ReadLine();
            }
        }
    }
}