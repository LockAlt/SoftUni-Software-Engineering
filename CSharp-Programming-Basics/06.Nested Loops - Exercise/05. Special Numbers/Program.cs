using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            // => от 1111 до 9999
            // не генерира всички числа в диапазона [1111-9999], а генерира всички четирицифрени числа ( 4 цикъла) които могат да се съставят от 1 до 9 !!! // 5 цикъла 5 цифрено число 
            for (int k = 1; k <= 9; k++)
            {
                for (int l = 1; l <= 9; l++)
                {
                    for (int j = 1; j <= 9; j++)
                    {
                        for (int i = 1; i <= 9; i++)
                        {
                            // правим проверка дали генерираното число е специално
                            if (N%i==0 && N%j==0 && N%l==0 && N%k==0)
                            {
                                Console.Write($"{k}{l}{j}{i} ");
                            }               
                        }
                    }

                }
            }
        }
    }
}