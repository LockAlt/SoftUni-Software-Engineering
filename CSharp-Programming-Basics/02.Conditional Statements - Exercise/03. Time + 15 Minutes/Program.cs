using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine()); //23
            int minutes = int.Parse(Console.ReadLine()); //50

            int timeinMin = minutes + hours * 60; // 50 + 23*60 = 1430
            timeinMin = timeinMin + 15; // 65 +23*60 = 1445 // Като добавим 15 мин към 23 часа и 50 мин става 24 часа и 5 мин 

            hours = timeinMin / 60; // 1445 / 60 = 24 ( ostatak 5)
            minutes = timeinMin % 60;  // 1445 % 60 = 5 ostatak
            //24:05 => 00:0
            if (hours >= 24)
            {
                hours = hours - 24; //24-24 = 0 //hours = 0
            }
            if (minutes < 10)
            {
                Console.WriteLine($"{hours}:0{minutes}");
            }
            else
            {
                Console.WriteLine($"{hours}:{minutes}");
            }
        }
    }
}