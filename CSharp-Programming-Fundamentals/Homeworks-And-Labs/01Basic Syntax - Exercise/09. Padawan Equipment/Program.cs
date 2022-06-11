using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double priceForSaber = double.Parse(Console.ReadLine());
            double priceForRobe = double.Parse(Console.ReadLine());
            double priceForBelt = double.Parse(Console.ReadLine());

            double totalNumberOfSaber = Math.Ceiling(studentsCount + (studentsCount * 0.1)); // double totalNumberOfSaber = Math.Ceiling(studentsCount *1.10 ); искат с 10% повече
            double numbersFreeBelts = studentsCount / 6;
            double finalPriceSaber = totalNumberOfSaber * priceForSaber;
            double finalPriceRobes = studentsCount * priceForRobe;
            double finalPriceBelt = (studentsCount - numbersFreeBelts) * priceForBelt;

            double totalPrice = finalPriceSaber + finalPriceRobes + finalPriceBelt;

            if (budget >= totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {Math.Abs(budget - totalPrice):f2}lv more.");
            }
        }
    }
}