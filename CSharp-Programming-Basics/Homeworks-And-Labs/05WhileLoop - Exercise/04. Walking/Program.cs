using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int steps = 0; // крачките които е изминала (пазим си общия брой на крачките тук)
            string input = Console.ReadLine(); // входа дали ще са крачките или Going home

            while (input!="Going home") // input >= 10 000 и това става но така  ще е по-трудно
            {
                steps += int.Parse(input); // Parsva - ме защото ако е различно от Going home ние сме получили стъпки и ни трябва int за да може да правим изчисления с тях 
                if (steps>=10000)
                {
                    break;
                }
                input = Console.ReadLine();
            }
            
            if(input == "Going home")
            {
                input = Console.ReadLine();
                steps += int.Parse(input);
            }

            if (steps<10000)
            {
                Console.WriteLine($"{10000-steps} more steps to reach goal."); //Console.WriteLine($"{Math.Abs(steps- 10000)} more steps to reach goal.");
            }
            else
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{steps - 10000} steps over the goal!"); // Console.WriteLine($"{Math.Abs(10000-steps)} steps over the goal!");
            }
        }
    }
}