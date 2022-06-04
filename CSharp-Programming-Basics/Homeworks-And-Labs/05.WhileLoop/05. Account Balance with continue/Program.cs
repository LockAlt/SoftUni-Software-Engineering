using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); // "-50"

            double account = 0;

            while (input != "NoMoreMoney") // "-50" != "NoMoreMoney" => Тrue
            {
                double amount = double.Parse(input);  //"-50" => -50
                if (amount < 0) // True 
                {
                    Console.WriteLine("Invalid operation!"); // Изписва се това и ако отдолу го нямахме това input = Console.ReadLine(); минава на continue и влиза отново в while (input != "NoMoreMoney") което пак става "-50" !=  "NoMoreMoney" и така продължава до безкрайност
                    input = Console.ReadLine(); // Това е много важно да го имаме защото ще стане безкраен цикъл  !!!!!!
                    continue; // Като имаме тук continue се връщаме отново на while(input!="NoMoreMoney") 
                }
                account += amount;

                Console.WriteLine($"Increase: {amount:f2}");

                input = Console.ReadLine(); 
            }

            Console.WriteLine($"Total: {account:f2}");
        }
    }
}