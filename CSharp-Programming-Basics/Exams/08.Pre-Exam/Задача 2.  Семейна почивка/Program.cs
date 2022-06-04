using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.  Да си създадем 4 променливи
            //	Бюджетът, с който разполагат – реално число в интервала[1.00 … 10000.00]
            double budget = double.Parse(Console.ReadLine());
            //	Брой нощувки – цяло число в интервала[0 … 1000]
            int nights = int.Parse(Console.ReadLine());
            //	Цена за нощувка – реално число в интервала[1.00 … 500.00]
            double priceForNight = double.Parse(Console.ReadLine());
            //	Процент за допълнителни разходи – цяло число в интервала[0 … 100]
            int percentForExpenses = int.Parse(Console.ReadLine());
            // да си създадем 1 променлива в която ще пазим общо колко пари ще ни излезе - money 
            // money = броя нощувки * цена за нощувка 
            double money = 0;
            
            // проверяваме дали брой нощувки > 7 и ако е True имаме 5% отстъпка ( да намалим money с 5%)
            if (nights>7)
            {
                priceForNight = priceForNight - (priceForNight * 5/100);  // priceForNight-=priceForNight * 5/100
            }

            money = nights * priceForNight;

            money = money + (budget*percentForExpenses / 100); // money = 760 + ( 800.5*2/100) => 760 +16.01 = 776.01
            
            if (budget>=money)
            {
                Console.WriteLine($"Ivanovi will be left with {budget-money:f2} leva after vacation.");
            }
            else
            {
                Console.WriteLine($"{money-budget:f2} leva needed.");
            }
            //money += Процент за допълнителни разходи от бюджета
            
            // проверяваме дали парите са достатъчни 
        }
    }
}