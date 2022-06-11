
using System;

namespace MultiplicationTable2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine()); // 5
            int times = int.Parse(Console.ReadLine()); // 14
            do //  Правим го в do while цикъл, защото са ни казали, че ако times е по-голямо от 10 искаме само веднъж да се умножи номера по дадения times затова първо ни дават да кажем 14 то се принтира и после проверява дали цикъла е true следователно 14>10 и е false и цикъла спира
            {
                Console.WriteLine($"{number} X {times} = {number * times}");
                times++;
            } while (times <= 10);
           
        }
    }
}