using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            // ДЕБЪГНИ !!!

            double moneySaved = 0;
            double moneyEvenBirthday = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    moneySaved = moneySaved + moneyEvenBirthday + 10; // !!!!! eto tova e glavnata promqna ako ne ti hrumne purviq nachin i ne moje da e moneySaved = monetEvenBirthday +10; zashtoto purva da kajem che moneySaved ti stava 6 zashtoto toyPrice = 6 i na vtorata godina vmesto da se dobavqt 10 kum tezi 6lv i da stane 16 savedMoney se refreshva samo na 10 !!
                }
                else
                {
                    moneySaved += toyPrice;
                }
            }
            double ostatak = moneySaved - washingMachinePrice; // Добавям си променливи просто и примерно тук ми се получава  -997.98 ( тук е отрицателно число но няма значение защото в иф няма да влезе това защото трябва да е moneySaved >= washingMachinePrice а то е moneySaved < washingMachinePrice)
            double diff = washingMachinePrice - moneySaved; // Добавям си променливи просто тук ми се получава 997.98 ( това ще влезе в елсе защото е moneySaved < washingMachinePrice)

            if (moneySaved >= washingMachinePrice)
            {
                Console.WriteLine($"Yes! {ostatak:F2}");
            }
            else
            {
                Console.WriteLine($"No! {diff:F2}");
            }
        }
    }
}