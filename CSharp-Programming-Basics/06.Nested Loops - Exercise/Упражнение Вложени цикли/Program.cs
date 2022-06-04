using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("1");
            //Console.Write("3");
            //Console.Write("3");
            //Console.Write("3");
            //Console.Write("3");
            //Console.WriteLine("");
            //Console.WriteLine();

            //int n = int.Parse(Console.ReadLine()); // _ _ _ _ _  => 1 2 3 4 5 ( пет цифрено число)
            //string currentNum = n.ToString();  // Превръша  n и го превръща в string // "12345"
            ////string currentNum  има дължина (currentNum.Length) = 4
            //// Позиция 0 : '1' => currentNum[0] //Това в скобите [] е позицията на числото 
            //// Позиция 1 : '2' => currentNum[1]  
            //// Позиция 2 : '3' => currentNum[2]
            //// Позиция 3 : '4' => currentNum[3]
            //// Позиция 4 : '5' => currentNum[4]


            //for (int i = 0; i < currentNum.Length; i++)
            //{
            //    Console.WriteLine(currentNum[i]);
            //}

            Console.WriteLine(5 % 1);
            Console.WriteLine(5 % 2);
            Console.WriteLine(5 % 3);
            Console.WriteLine(5 % 4);
            Console.WriteLine(5 % 5);



            // _ _ _ _  => от 1111 до 9999 ??

            ////=> от 1 до 9

            //for (int i = 1; i <= 9; i++)
            //{
            //     Console.Write(i + " "); // => Console.WriteLine($"{i} ");  !!!!!
            //}


            //// => от 11 до 99

            //    for (int j = 1; j <= 9; j++)
            //    {
            //        for (int i = 1; i <= 9; i++)
            //        {
            //            Console.Write($"{j}{i} ");
            //        }
            //    }

            // => от 111 до 999

            //for (int l = 0; l <= 9; l++)
            //{
            //    for (int j = 1; j <= 9; j++)
            //    {
            //        for (int i = 1; i <= 9; i++)
            //        {
            //            Console.Write($"{l}{j}{i} ");
            //        }
            //    }

            //}

            // => от 1111 до 9999

            for (int k = 1; k <= 9; k++)
            {
                for (int l = 1; l <= 9; l++)
                {
                    for (int j = 1; j <= 9; j++)
                    {
                        for (int i = 1; i <= 9; i++)
                        {
                            Console.Write($"{k}{l}{j}{i} ");
                        }
                    }

                }
            }









        }
    }
}


