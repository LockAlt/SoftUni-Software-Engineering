using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMin = int.Parse(Console.ReadLine());

            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMin = int.Parse(Console.ReadLine());

            examMin = examMin + examHour * 60; 
            arriveMin = arriveMin + arriveHour * 60; 

            int difference = 0;
            int diffHour = 0;
            int diffMin = 0;

            if (examMin < arriveMin) 
            {
                Console.WriteLine("Late");
                difference = arriveMin - examMin;
                diffHour = difference / 60;
                diffMin = difference % 60;
                if (diffHour >= 1)
                {
                    if (diffMin < 10)
                    {
                        Console.WriteLine($"{diffHour}:0{diffMin}hours after the start");
                    }
                    else
                    {
                        Console.WriteLine($"{diffHour}:{diffMin}hours after the start");
                    }
                }
                else
                {
                    Console.WriteLine($"{diffMin} minutes after the start");
                }
            }
            else if ((examMin == arriveMin) || (examMin - arriveMin <= 30))
            {
                Console.WriteLine("On time");
                if (examMin != arriveMin)
                {
                    difference = examMin - arriveMin;
                    Console.WriteLine($"{Math.Abs(difference)}minutes before the start");
                }
            }
            else
            {
                Console.WriteLine("Early");
                difference = examMin - arriveMin;               
                diffHour = difference / 60;
                diffMin = difference % 60;               
                if (diffHour >= 1)              
                {
                    if (diffMin < 10)
                    {
                        Console.WriteLine($"{diffHour}:0{diffMin}hours before the start");
                    }
                    else
                    {
                        Console.WriteLine($"{diffHour}:{diffMin}hours before the start");
                    }
                }
                else
                {
                    Console.WriteLine($"{diffMin} minutes before the start");
                }
            }
        }
    }
}