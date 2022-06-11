using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int oddnumberscount = int.Parse(Console.ReadLine());
            int sum = 0;
            int currentnumber = 0; // може това да го нямаме а да е дадено долу

            for (int i = 0; i < oddnumberscount; i++)
            {
                currentnumber = 1 + (i * 2); // int currentnumber =  1 + (i * 2); ето така направо променливата в цикъла 
                Console.WriteLine(currentnumber);
                sum += currentnumber;
            }
            Console.WriteLine($"sum: {sum}");

        }
    }
}