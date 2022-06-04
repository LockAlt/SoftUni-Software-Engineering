using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Със while е много по-трудно такива комбинации

            int start = int.Parse(Console.ReadLine()); // 1
            int end = int.Parse(Console.ReadLine());  // 10

            int magicNum = int.Parse(Console.ReadLine()); // 5

            int counter = 0;
            
            int num1 = start; // num1 = 1

            while (num1 <= end) // 1<= 10
            {
                int num2 = start; // num2 = 1 
                while (num2 <= end) // 1 <= 10  ТОЗИ!!
                {
                    counter++; // -> counter = 1

                    if (num1 + num2 == magicNum) // 1+1  = 5 
                    {
                        Console.WriteLine($"Combination N:{counter} ({num1} + {num2} = {magicNum})");
                        return;
                    }
                    num2++; // num2 = 2 и се връша в ТОЗИ ЦИКЪЛА (ТОЗИ) -> така съм го маркирал  и тества с 2 и така като num2 стане 10 отива към num1 и го увеличава от 1 на 2  
                }
                num1++;
            }
            Console.WriteLine($"{counter} combinations - neither equals {magicNum}"); 
        }
    }
}