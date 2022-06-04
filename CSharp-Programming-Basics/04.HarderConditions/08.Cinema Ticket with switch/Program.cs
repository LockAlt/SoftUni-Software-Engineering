using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            switch (day) // Пишем името на променливата, която ще я сравняваме и ще работим с нея в този случай day 
            {
                case "Monday":
                case "Tuesday":
                case "Friday":
                    Console.WriteLine(12);
                    break;
                case "Wednesday":
                case "Thursday":
                    Console.WriteLine(14);
                    break;
                default:
                    Console.WriteLine(16);
                    break;
            }
        }
    }
}