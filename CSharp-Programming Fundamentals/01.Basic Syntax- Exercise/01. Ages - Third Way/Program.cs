using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());

            switch (age)
            {
                case >= 0 and <= 2:
                    Console.WriteLine("baby");
                    break;
                case > 2 and <= 13:
                    Console.WriteLine("child");
                    break;
                case > 13 and <= 19:
                    Console.WriteLine("teenager");
                    break;
                case > 19 and <= 65:
                    Console.WriteLine("adult");
                    break;
                default:
                    Console.WriteLine("elder");
                    break;
            }
        }
    }
}

   