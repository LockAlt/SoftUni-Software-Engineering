using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            double bonus = 0;
            if (num <= 100)
            {
                bonus = 5;
            }
            else if (num > 100 & num < 1000)
            {
                bonus = num * (20 / 100.0); bonus = num * 0.1; // Това може да е записано като (10/100.0) като долното. Това са проценти.
            }
            else (num > 1000)
            {
                bonus = num * 0.1;
            }
            if (num % 2 == 0)
            {
                bonus = bonus + 1; // Също може и така bonus+=1
            }
            if (num % 10 == 5) // 142/10 = 14 ;  142%10 = 2 
            {
                bonus = bonus + 2;   //bonus+=2
            }
            Console.WriteLine(bonus);
            Console.WriteLine(num + bonus);
        }
    }
}