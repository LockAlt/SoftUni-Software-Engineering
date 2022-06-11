using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int strongNumber = int.Parse(Console.ReadLine());
            int strongNumberCopy = strongNumber;
            int sum = 0;
            // 145 -> 1 , 4 , 5

            while (strongNumber > 0) // На следващата итерация числото ни вече е 14
            {
                int factorialNumber = 1; // номера на факториела  
                int currentNumber = strongNumber % 10; // 145 % 10 - > 5 ; 14 % 10 -> 4 винаги ни връща псоледната цифра ; 1%10 = 1
                strongNumber /= 10; // number = number / 10;    145 / 10 -> 14   ; 14 /10 = 1
                for (int i = 2; i <= currentNumber; i++) // факториела  // започваме от 2 защото 1*1 = 1 =>> 2*1 = 2 и няма смисъл да почваме от 1
                {
                    factorialNumber = factorialNumber * i; // текущото число по факториелното число  // 1*2 = 2 -> 2*3 = 6 -> 6*4 = 24 ->  24*5= 120 
                }

                sum += factorialNumber; // 120

            }
            Console.WriteLine(sum == strongNumberCopy ? "yes" : "no"); // Тернарен оператор
        }
    }
}