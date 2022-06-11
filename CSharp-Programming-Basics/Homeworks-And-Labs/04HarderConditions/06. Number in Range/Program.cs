using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num= int.Parse(Console.ReadLine());
            if (num >= -100 && num <= 100 && num != 0) // <- tuk nqma ; nakraq !!!!
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}