using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //време за обедна почивка => 8/8
           //1/8 = за обяд
           //1/4 = за отдих = 2/8
           // 1/8(за обяд) + 2/8(за отдих) = 3/8 (сме заети)
           // колко време може да отделим на сериала =>  8/8 - 3/8 = 5/8 от обедната почивка  // Ако почивката е 120 мин => 1 част 15 мин => 5 части *15 = 75 мин за сериала

         
            string seriesName = Console.ReadLine();
            int seriesTime = int.Parse(Console.ReadLine());
            int lunchBreakime = int.Parse(Console.ReadLine());

            double timeForSeries = lunchBreakime * 5.0 / 8; // Trqbva da e 5.0/8 zashtoto ako e 5/8 moje da stane int preobrazuvanoto chislo
            if (timeForSeries >= seriesTime)
            {
                Console.WriteLine($"You have enough time to watch {seriesName} and left with {Math.Ceiling(timeForSeries - seriesTime)} minutes free time."); // Сериал 60 мин, свободно време 70 => 70-60 = 10 minutes free time
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {Math.Ceiling(seriesTime - timeForSeries)} more minutes."); // Сериал 60 мин, свободно време 50 мин => 50-60 = 10 more minutes needed
            }
            
        }
    }
}