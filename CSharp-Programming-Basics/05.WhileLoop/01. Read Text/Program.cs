using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string text = Console.ReadLine(); // Това ни трябва за да може да използваме тази променлива отдолу в while цикъла

            while (text != "Stop") 
            {
                Console.WriteLine(text);
                text = Console.ReadLine();
            }

            // Това е другия вариант
            
            //while (true)
            // {
            //    string input = Console.ReadLine();
            //    if (input == "Stop")
            //    {
            //        break;
            //    }
            //    Console.WriteLine(input);
            // }

        }
    }
}