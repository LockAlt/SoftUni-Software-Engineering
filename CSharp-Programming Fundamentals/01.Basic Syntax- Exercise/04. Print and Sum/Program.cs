using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            int sum = 0;
             // Закоментираното е с различна променлива ( едно и също е ) 
            for (int i = startNum; i <= endNum; i++)  // for (int value = startNum; value <= endNum; value++)
            {
                Console.Write($"{i} "); // Искат го на един ред и имаме разстояние между тях затова съм го направил така  // Console.Write(value);
                sum +=i;               // sum+= value
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}