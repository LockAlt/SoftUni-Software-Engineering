using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double totalAccumulatedMoney = 0; // общо събраните пари

            while (command != "Start")
            {
                double inputMoney = double.Parse(command); // Така парсвахме от стринг в инт или доубле 
                if (inputMoney == 0.1 || inputMoney == 0.2 || inputMoney == 0.5 || inputMoney == 1 || inputMoney == 2)
                {
                    totalAccumulatedMoney += inputMoney;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {inputMoney}");
                }
                command = Console.ReadLine(); // Четем следваща команда докато не дойде старт! НЕ ЗАБРАВЯЙ !!!
            }
            command = Console.ReadLine();
            double totalPrice = 0;

            while (command != "End")
            {
                switch (command)  // Всеки един ор break излиза от switch и продължава надолъ където изчислява сметката и стига до най-долу при command = Console.ReadLine(); където чете нова команда и се връща в while цикъла и следвателно ако не е End влиза в switch  
                {
                    case "Nuts":
                        totalAccumulatedMoney -= 2.0;         
                        break;
                    case "Water":
                        totalAccumulatedMoney -= 0.7;
                        break;
                    case "Crisps":
                        totalAccumulatedMoney -= 1.5;
                        break;
                    case "Soda":
                        totalAccumulatedMoney -= 0.8;
                        break;
                    case "Coke":
                        totalAccumulatedMoney -= 1.0;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        command = Console.ReadLine(); 
                        continue; 

                }
                if (totalAccumulatedMoney >= 0)
                {
                   Console.WriteLine($"Purchased {command.ToLower()}"); // ToLower защото искаме примерно като е въвел Coke да ни го изпринти като coke, чрез ToLower се превръща ЦЕЛИЯ string в малки букви 
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"Change: {totalAccumulatedMoney:f2}");
        }
    }
}