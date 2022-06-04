using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int day = 1; day <= 28; day++)
            //{  
            //    for (int hour = 0; hour <= 23; hour++)  // Този цикъла чака този долу
            //    {
            //        for (int min = 0; min <= 59; min++) //А пък този  чака този долу
            //        { 
            //            Console.WriteLine($"{day:d2}.02.2022:{hour:d2}:{min:d2}");

            //         }
            //    }
            //}
             

            // Виж разликата между двата !

            for (int day = 1; day <= 28; day++)
            {
                Console.WriteLine($"{day:d2}.02.2022");
                for (int hour = 0; hour <= 23; hour++)  // Този цикъла чака този долу
                {
                    for (int min = 0; min <= 59; min++) //А пък този  чака този долу
                    {
                        Console.WriteLine($"{hour:d2}:{min:d2}");

                    }
                }
            }





        }
    }
}