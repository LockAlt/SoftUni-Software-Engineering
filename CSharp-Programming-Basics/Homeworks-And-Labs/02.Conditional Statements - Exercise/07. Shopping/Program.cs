using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            int videocardQuantity = int.Parse(Console.ReadLine());
            int processorsQuantity = int.Parse(Console.ReadLine());
            int ramMemoryQuantity = int.Parse(Console.ReadLine());

            double videocardPrice = videocardQuantity * 250;
            double processorsPrice = processorsQuantity * (videocardPrice * 0.35);
            double ramMemoryPrice = ramMemoryQuantity * (videocardPrice * 0.10);
            double totalPrice = videocardPrice + processorsPrice + ramMemoryPrice;
            if (videocardQuantity > processorsQuantity)
            {
                totalPrice = totalPrice - (totalPrice * 0.15);
            }

            double difference = budget - totalPrice; // Ако budget = 500,  а totalPrice =400 differenece = 500-400 = 100

            if (difference >= 0)
            {
                Console.WriteLine($"You have {difference:F2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs( difference ):F2} leva more!");  // Ako budget = 300 a totalPrice =400 difference = -100 zatova izpolzvame Math.Abs za da e polojitelno chilso
            }
        }
    }
}