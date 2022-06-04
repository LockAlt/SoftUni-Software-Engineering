using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ticketType = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());

            double income = row * col;
            switch (ticketType)
            {
                case "Premiere":
                    income = income * 12.00;
                    break;
                case "Normal":
                    income = income * 7.50;
                    break;
                default:
                    income = income * 5.00;
                    break;
            }
            Console.WriteLine("{0:f2} leva", income); // Console.WriteLine($"{income:F2} leva); // Console.WriteLine("{2:F2} leva" , income ,row ,col // I tuk shte izbere 2 row 
        }
    }
}