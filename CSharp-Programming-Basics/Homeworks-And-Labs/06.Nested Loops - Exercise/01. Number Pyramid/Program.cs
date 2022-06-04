using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine()); // Последното число което трябва да отпечатаме
            int currentNum = 1; // Числото което отпечатваме в пирамидата

            for (int row = 1; row <= n ; row++)
            {
                for (int j = 1; j <= row; j++) // Това j представлява все едно да си следим на 1 ред има 1 число на 2 ред има 2 числа на 3 ред има 3 числа и тн.
                {

                    Console.Write(currentNum+" ");
                    currentNum++;
                        if (currentNum > n)
                    {
                        break;
                    }
                }
                Console.WriteLine();// Това е когато сме си отпечатали достатъчен брой числа на определения ред да отиваме на следващия ред //Console.WriteLine("");
                if (currentNum > n)
                {
                    break;
                }
            }

        }
    }
}