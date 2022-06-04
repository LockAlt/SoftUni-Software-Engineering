using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // _ _ _ _           
            //  int num = 1234

            // По този начин отделяме всяка една от цифрите на числото !
            // int d4 = num % 10; (4)
            // int d3 = num / 10 % 10;  (3)
            // int d2 = num / 100 % 10; (2)
            // int d1 = num / 1000; (1)

            //Console.WriteLine($"d:{d1}");
            //Console.WriteLine($"d:{d2}");
            //Console.WriteLine($"d:{d3}");
            //Console.WriteLine($"d:{d4}");


            int first = int.Parse(Console.ReadLine());  // Пишем четирицифрено число  // d1 d2 d3 d4  /1234 
            int second = int.Parse(Console.ReadLine());  // Пишем четирицифрено число   // d1 d2 d3 d4 / 4567  
            // d1 => 1,2,3,4  => нечетени 1,3
            // d2 => 2,3,4,5 => нечетени 3,5
            // d3 => 3,4,5,6 => нечетени 3,5
            // d4 => 4,5,6,7 => нечетени 5,7

            // 1335 ; 3335 ; 1355 ; 1337 и тн. примерно с тези примери от нечетните горе 

            for (int d1 = first / 1000; d1 <= second / 1000; d1++)
            {
                if (d1 % 2 == 0)
                {
                    continue;
                }
                for (int d2 = first / 100 % 10; d2 <= second / 100 % 10; d2++)
                {
                    if (d2 % 2 == 0)
                    {
                        continue;
                    }
                    for (int d3 = first / 10 % 10; d3 <= second / 10 % 10; d3++)
                    {
                        if (d3 % 2 == 0)
                        {
                            continue;
                        }
                        for (int d4 = first % 10; d4 <= second % 10; d4++)
                        {
                            if (d4 % 2 == 0)
                            {
                                continue;
                            }
                            Console.Write($"{d1}{d2}{d3}{d4} ");
                        }
                    }
                } 
            }
        }
    }
}