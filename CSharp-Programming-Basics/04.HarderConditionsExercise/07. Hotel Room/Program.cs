using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int overnight = int.Parse(Console.ReadLine());
 
            double StPrice = 0;
            double ApPrice = 0;

            if (month == "May" || month == "October")
            {
                StPrice = 50.0;
                    if (overnight > 7 && overnight<14)
                    {
                    StPrice = StPrice - (StPrice * 0.05);
                    }
                    if (overnight > 14)
                    {
                    StPrice = StPrice - (StPrice * 0.30);
                    }
                   ApPrice = 65.0;
                    if (overnight > 14)
                    {
                    ApPrice = ApPrice - (ApPrice * 0.10);
                    }
            }
            else if (month == "June" || month== "September")
            {
                StPrice = 75.20;
                    if (overnight>14)
                    {
                    StPrice = StPrice - (StPrice * 0.20);
                    }
                  ApPrice = 68.70;
                        if (overnight>14)
                        {
                    ApPrice = ApPrice - (ApPrice * 0.10);
                        }

            }
            else if ( month == "July"|| month == "August")
            {
                StPrice = 76.00;
                  ApPrice = 77.00;
                    if (overnight > 14)
                    {
                    ApPrice = ApPrice - (ApPrice * 0.10);
                    }

            }
            double Ap = 0;
            double St = 0;
             Ap = ApPrice * overnight; // Tuk  im smqtam poslednata cenata
             St = StPrice * overnight; // Tuk  im smqtam poslednata cenata
            Console.WriteLine($"Apartment: {Ap:F2} lv.");
            Console.WriteLine($"Studio: {St:F2} lv.");
        }
    }
}