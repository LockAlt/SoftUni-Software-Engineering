using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            double percentCommision = 0;
            switch (city)
            {
                case "Sofia":
                    if (sales > 0 && sales <= 500)
                    {
                        percentCommision = 0.05;// 5/100.0
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        percentCommision = 0.07;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        percentCommision = 0.08;
                    }
                    else  
                        percentCommision = 12 / 100.0; // Moje i s 0.12             
                    break;
                case "Varna":
                    if (sales > 0 && sales <= 500)
                    {
                        percentCommision = 0.045;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        percentCommision = 0.075; // 7.5/100.0
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        percentCommision = 0.10;
                    }
                    else
                    {
                        percentCommision = 13 / 100.0;
                    }
                    break;
                case "Plovdiv":
                    if (sales > 0 && sales <= 500)
                    {
                        percentCommision = 0.055;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        percentCommision = 0.08;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        percentCommision = 0.12;
                    }
                    else
                    {
                        percentCommision = 14.5 / 100.0; // Moje i s 0.145
                    }
                    break;
            }

            double commision = percentCommision * sales;


            if (commision > 0) // Tova oznachava che e vleznalo v nqkoi if ili else if i vsichko e vqrno
            {
                Console.WriteLine($"{commision:f2}");
            }
            else // Sledovatelno tuk oznachava che ili imeto ili e bilo otricatelno chislo i ne e vleznalo v commision > 0
            {
                Console.WriteLine("error");
            }
        }
    }
}