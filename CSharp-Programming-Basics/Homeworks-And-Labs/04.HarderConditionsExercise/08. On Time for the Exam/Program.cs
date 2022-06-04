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

            examMin = examMin + examHour * 60; // Pravim gi v minuti
            arriveMin = arriveMin + arriveHour * 60; // Pravim gi v minuti

            int difference = 0;
            int diffHour = 0;
            int diffMin = 0;

            if (examMin < arriveMin) // Проверяваме дали студента закъснява 
            {
                Console.WriteLine("Late");
                //намираме разликата във времето на пристигане 
                difference = arriveMin - examMin;
                //Преобразуваме разликата в минути и часове 
                diffHour = difference / 60;
                diffMin = difference % 60;
                //Проверяваме дали сзакъснява с повече от 1 час
                if (diffHour >=1)
                    //Проверяваме дали минутите са по-малко от 10 и ако са ги отпечатваме с водеща 0
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
           // Проверяваме дали студента е на време за изпита
            else if ((examMin == arriveMin) || (examMin - arriveMin <= 30))
            {
                Console.WriteLine("On time");
                if (examMin != arriveMin)
                {
                    difference = examMin- arriveMin;
                    Console.WriteLine($"{difference}minutes before the start");
                }

            }
            // Проверяваме дали студента е подранил за изпита 
            else
            {
                Console.WriteLine("Early");
                //намираме разликата във времето на пристигане 
                difference = examMin- arriveMin;
                //Преобразуваме разликата в минути и часове 
                diffHour = difference / 60;
                diffMin = difference % 60;
                //Проверяваме дали подранява с повече от 1 час
                if (diffHour >= 1)
                //Проверяваме дали минутите са по-малко от 10 и ако са ги отпечатваме с водеща 0
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