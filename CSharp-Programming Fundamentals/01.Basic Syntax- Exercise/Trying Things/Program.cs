using System;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string command = Console.ReadLine();
            //double totalAccumulatedMoney = 0; // общо събраните пари

            //while (command != "Start")
            //{
            //    double inputMoney = double.Parse(command); // Така парсвахме от стринг в инт или доубле 
            //    if (inputMoney == 0.1 || inputMoney == 0.2 || inputMoney == 0.5 || inputMoney == 1 || inputMoney == 2)
            //    {
            //        totalAccumulatedMoney += inputMoney;
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Cannot accept {inputMoney}");
            //    }
            //    command = Console.ReadLine(); // Четем следваща команда докато не дойде старт! НЕ ЗАБРАВЯЙ !!!
            //}
            //command = Console.ReadLine();
            //double totalPrice = 0;

            //while (command != "End")
            //{
            //    switch (command)
            //    {
            //        case "Nuts":
            //            totalPrice = 2.0;        
            //            break;
            //        case "Water":
            //            totalPrice = 0.7;
            //            break;
            //        case "Crisps":
            //            totalPrice = 1.5;
            //            break;
            //        case "Soda":
            //            totalPrice = 0.8;
            //            break;
            //        case "Coke":
            //            totalPrice = 1.0;
            //            break;
            //        default:
            //            Console.WriteLine("Invalid product"); 
            //            break;  // ТУК ПОНЕЖЕ СЪМ СЛОЖИЛ break ИЗЛИЗА ОТ default И ПРОДЪЛЖАВА НАДОЛУ И КАТО ВЛЕЗНЕ В if ПРИНТИ ЗА ПРОДУКТА КОЙТО Е НЕВАЛИДЕН И ТОВА Е ГРЕШКА
            //    }
            //    if (totalAccumulatedMoney >= totalPrice)
            //    {
            //        totalAccumulatedMoney -= totalPrice;
            //        Console.WriteLine($"Purchased {command.ToLower()}"); // ToLower защото искаме примерно като е въвел Coke да ни го изпринти като coke, чрез ToLower се превръща целия string в малки букви 
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sorry, not enough money");
            //    }

            //    command = Console.ReadLine();
            //}
            //Console.WriteLine($"Change: {totalAccumulatedMoney:f2}");


            // СЛЕДВАЩОТО Е ОБЪРКВАЩО НО ГЛАВНО НЯМА РАЗЛИКА ДАЛИ ЩЕ Е КАТО num3 ИЛИ КАТО num, num1

            //int num = int.Parse(Console.ReadLine()); // 5
            //Console.WriteLine($"{num}   ");          // 5
            //Console.WriteLine($"   {num}   ");       //    5

            //int num1 = int.Parse(Console.ReadLine()); //5
            //Console.WriteLine($"    {num1}");         //    5


            //int num2 = int.Parse(Console.ReadLine()); //6
            //Console.WriteLine(num2 + "");             // 6

            int num3 = int.Parse(Console.ReadLine()); //6
            Console.WriteLine(num3 + "    ");            //  6
            Console.WriteLine(num3 + "");            //  6
        }
    }
}