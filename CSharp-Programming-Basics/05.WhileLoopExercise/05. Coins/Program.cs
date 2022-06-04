using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double changeToReturn = 100* double.Parse(Console.ReadLine()); // монети които ще връщаме // 5,23 => 523 защото с дробни числа не е точно изчислението ни 
           
            int count = 0; // монети които ще връщаме бройката им 
            // 2лв., 1лв., 0.50ст., 0.20ст., 0.10ст., 0.05ст, 0.02 ст., 0.01ст.
            //5,23 => 2*2.00 + 1.00 + 0.20 + 0.02 + 0.01 

            // 5,23 - 2 => 3,23 (count = 1)
            // 3,23 - 2 => 1,23 (count = 1+1 = 2)
            // 1,23 - 1 => 0.23 (count = 2+1 = 3)
            // 0.23 - 20 => 0.03 (count = 3+1= 4)
            // 0.03 -0.02 => 0.01 (count = 4+1 = 5)
            // 0.01 -0.01 => 0.00 (count = 5+1 =6)

            while (changeToReturn > 0) // Когато станат 0 спираме да връщаме ресто
            {
                if (changeToReturn >= 200)
                {
                    changeToReturn -= 200; // changeToReturn = changeToReturn -2 
                    count++;
                }
                else if (changeToReturn >= 100)
                {
                    changeToReturn -= 100;
                    count++;
                }
                else if (changeToReturn >= 50)
                {
                    changeToReturn -= 50;
                    count++;
                }
                else if (changeToReturn >= 20)
                {
                    changeToReturn -= 20;
                    count++;
                }
                else if (changeToReturn >= 10)
                {
                    changeToReturn -= 10;
                    count++;
                }
                else if (changeToReturn >= 5)
                {
                    changeToReturn -= 5;
                    count++;
                }
                else if (changeToReturn >= 2)
                {
                    changeToReturn -= 2;
                    count++;
                }
                else if (changeToReturn >= 1)
                {
                    changeToReturn -= 1;
                    count++;
                }
                else // else (changeToReturn < 1) За да се подсигорим
                {
                    changeToReturn = 0;
                }

            }
            Console.WriteLine(count);

        }
    }
}
