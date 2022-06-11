using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine()); //3 
            
            int biggestNumNow = int.MinValue; // MinValue go slagame za da mojem da sravnqvame s otricatelni chisla zashtoto nqma po-malko chislo ot int.MinValue
            int smallestNumNow = int.MaxValue; // Sushtata logika e i tuk

            for (int i = 0; i < n; i++) // 
            {
                int num = int.Parse(Console.ReadLine()); // 36 , 5 ,6

                if (num>biggestNumNow) // 36 vliza tuk purvo i biggestNumNow stava 36 posle 5 ne vliza tuk posle 6 ne vliza tuka
                {
                    biggestNumNow = num;
                }
                if (num < smallestNumNow) // Kato imame dva if i dvata shte gi proveri programata a ako imahme else if vtoriq nqmashe da go proveri // Posle 36 vliza i tuka no puk 5<36 i posle i 6 ne vliza tuk sledovatelno smallestNum si ostava 5
                {
                    smallestNumNow = num;
                }
            }
            Console.WriteLine($"Max number: {biggestNumNow}"); //36
            Console.WriteLine($"Min number: {smallestNumNow}"); //5

            // -500 < -100 ; 100<500 !!
        }
    }
}