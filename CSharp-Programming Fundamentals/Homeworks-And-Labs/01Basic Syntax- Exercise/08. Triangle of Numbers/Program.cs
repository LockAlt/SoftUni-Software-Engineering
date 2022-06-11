using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // row - ред
            // column - колона
           
           int num = int.Parse(Console.ReadLine());
            for (int column = 1; column <= num; column++)
            {
                for (int row = 1; row <= column; row++) 
                {
                   Console.Write($"{column} ");  //Console.Write(row+" ");  Няма разлика  //Console.Write(row + "") Ако е така цифрите ще са залепени
                }
                Console.WriteLine();
            }
        }
    }
}