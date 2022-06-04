using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyNeedForExcursion = double.Parse(Console.ReadLine()); // нужните пари за почивка
            double availableMoney = double.Parse(Console.ReadLine()); // парите които има до момента

            string input = string.Empty; // видът действие което ще е или spend или save
            double money = 0; // парите които тя спестява или харчи

            int daysCount = 0; // Дните в които тя се опитва да спести или да харчи
            int spendCount = 0; // ПОРЕДНИ дни, в които харчи

            while (availableMoney < moneyNeedForExcursion)
            {
                input = Console.ReadLine(); 
                money = double.Parse(Console.ReadLine());
                daysCount++; 

                if (input == "save")
                {
                    availableMoney += money;
                    spendCount = 0;
                }
                else
                {
                    availableMoney -= money; //availableMoney = 20 ; money = 50 => -30 следователно ако се получи отризателно число влиза в долния if
                    
                    if (availableMoney<0)
                    {
                        availableMoney = 0;
                    }

                    spendCount++;
                    
                    if (spendCount == 5)

                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine($"{daysCount}");
                        break;
                    }
                }

            }

            if (availableMoney>=moneyNeedForExcursion)
            {
                Console.WriteLine($"You saved the money for {daysCount} days.");
            }
        }
    }
}