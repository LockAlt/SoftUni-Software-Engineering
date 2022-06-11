using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes = minutes + 30;
            
            if(minutes>=60)
            {
                hours += 1; // hours++
                minutes = minutes - 60; // minutes -= 60
            }
            
            if (hours == 24)
            {
                hours = 0;       
            }
      
            Console.WriteLine($"{hours}:{minutes:d2}");// чрез d2 тези водещи нулще се покажат само ако е единично число при минутите например 9 мин ще стане 09 но ако е двуцифрено число примерно 17 няма да се промени нищо
        }
    }
}