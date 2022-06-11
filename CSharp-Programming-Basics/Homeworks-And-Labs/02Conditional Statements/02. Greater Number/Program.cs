using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            //num1 > num2
            //num1 < num2 
            //num1 = num2

            //if (num1 > num2)
            //{
            //    Console.WriteLine(num1);
            //}

            //if(num2 > num1)
            //{
            //    Console.WriteLine(num2);
            //}

            //if (num2 = num1)
            //{
            //    Console.WriteLine(num2);
            //}

            // Tova gore moje da stane, no e po-udobno i vqrno tova otdolu
            if (num1 > num2)
            {
                Console.WriteLine(num1);
            }
            else
            {
                Console.WriteLine(num2);
            }
        }
    }
}