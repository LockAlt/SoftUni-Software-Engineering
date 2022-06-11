using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            for (int hour = 0; hour <= 23; hour++)  // Този цикъл чака този долу
            {
                for (int min = 0; min <= 59; min++) //А пък този  чака този долу
                {
                    for (int sec = 0; sec <= 59; sec++)
                    {
                        Console.WriteLine($"{hour:d2}:{min:d2}:{sec:d2}");
                    }
                }
            }
        }
    }
}