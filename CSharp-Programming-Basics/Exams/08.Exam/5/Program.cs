using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            int days = 1;
            int startMetres = 5364;
            int goal = 8848;
            int metersAll = 0;

            while (input!="END")
            {
                if (input == "Yes")
                {
                    days++;
                    if (days>5)
                    {
                        break;
                    }
                }
                int metersClimbed = int.Parse(Console.ReadLine());
                metersAll += metersClimbed;
                if (metersAll + startMetres >= goal)
                {
                    Console.WriteLine($"Goal reached for {days} days!");
                    break;
                }
                input = Console.ReadLine();
            }
            
            if (days>5 || input =="END")
            {
                Console.WriteLine("Failed!");
                Console.WriteLine($"{metersAll + startMetres}");
            }                    
        }
    }
}