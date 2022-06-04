using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // purvo izbirame kolko chisla trqbva da smqtame primerno 2
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
               int numberSum= int.Parse(Console.ReadLine()); // i = 0 --> i<n --> 0<2 --> ni dava da vuvedem chislo priermno 10  i sumata e ravna na 10 posle pravi edna vrutka i sushtoto se sluchva i nie kazvame che sledvashtoto chislo e 20 i imame 10+=20 ( 10 = 10+20)--> 30 i se printira sborut im 
                sum += numberSum;
            }
            Console.WriteLine(sum);
        }
    }
}