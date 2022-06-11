using System;

namespace _7._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double totalAccumulatedMoney = 0;

            while (input != "Start")
            {
                double coin = double.Parse(input);
                if (coin == 0.1 || coin == 0.2 || coin == 0.5 || coin == 1 || coin == 2)
                {
                    totalAccumulatedMoney += coin;
                    input = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                    input = Console.ReadLine();
                    continue;
                    
                }
            }
            
            string input2 = Console.ReadLine();   
            while (input2 != "End")
            {
                switch (input2)
                {
                    case "Nuts":
                        if (totalAccumulatedMoney < 2)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {
                            totalAccumulatedMoney -= 2;
                            Console.WriteLine("Purchased nuts");
                        }
                        break;
                    case "Water":
                        if (totalAccumulatedMoney < 0.7)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {
                            totalAccumulatedMoney -= 0.7;
                            Console.WriteLine("Purchased water");
                        }
                        break;
                    case "Crisps":
                        if (totalAccumulatedMoney < 1.5)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {
                            totalAccumulatedMoney -= 1.5;
                            Console.WriteLine("Purchased crisps");
                        }
                        break;
                    case "Soda":
                        if (totalAccumulatedMoney < 0.8)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {
                            totalAccumulatedMoney -= 0.8;
                            Console.WriteLine("Purchased soda");
                        }
                        break;
                    case "Coke":
                        if (totalAccumulatedMoney < 1)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {
                            totalAccumulatedMoney -= 1;
                            Console.WriteLine("Purchased coke");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                input2 = Console.ReadLine();
            }
            Console.WriteLine($"Change: {Math.Abs(totalAccumulatedMoney):f2}");
        }
    }
}