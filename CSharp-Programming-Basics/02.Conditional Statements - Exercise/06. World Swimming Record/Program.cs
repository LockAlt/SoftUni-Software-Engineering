using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timeInSeconds1Metre = double.Parse(Console.ReadLine());

            double IvanNeedToSwimInSec = distanceInMeters * timeInSeconds1Metre;
            double MeterDelayInSec = (Math.Floor(distanceInMeters / 15)) * 12.5;  // Za da se zakrugli do dolnoto chislo
            double totalTime = IvanNeedToSwimInSec + MeterDelayInSec;
            if (totalTime < recordInSeconds)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {Math.Abs(totalTime - recordInSeconds):F2} seconds slower.");
            }



        }
    }
}