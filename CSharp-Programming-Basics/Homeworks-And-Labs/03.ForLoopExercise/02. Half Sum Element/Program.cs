using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());//n = 3 // Числото е цяло, защото няма как в цикъла да се сложи дробно число примерно 2.5 и да се направят 2.5 изпълнения на цикъла

            int sum = 0;
            int maxNum = int.MinValue; // Когато търсим най-голямото число започваме от най-малкото с MinValue,а когато търсим най-малкото число започваме от най-голямот с MaxValue

            for (int i = 1; i <= n; i++) // => i =1 ; i = 2; i=3  |   for (int i = 0; i < n; i++) => i=0 ; i=1 ; i=2 Двата варианта са еднакви
            {
                int num = int.Parse(Console.ReadLine()); // 6, 5, 12

                sum += num; // sum = 6 --> sum =6+5 = 11 --> sum = 11+12 = 23
                if (num > maxNum) // MaxNum = 12
                {
                    maxNum = num;
                }    
            }
            
            sum = sum - maxNum; // sum = 23 -12 ==> sum = 11  
                
                if (sum == maxNum) // Ако новата сума == макс сумата тогава влиза тук // 11 = 12 koeto ne e vqrno i vliza v else
                {
                    Console.WriteLine("Yes");
                    Console.WriteLine("Sum = " + maxNum); // Може и така Console.WriteLine("Sum = "+sum);
                }
                else 
                {
                    Console.WriteLine("No");
                    Console.WriteLine("Diff = " + Math.Abs(maxNum-sum)); // maxNum - sum ==> 12 - 11 = 1 Diff = 1 
                }
        }
    }
}