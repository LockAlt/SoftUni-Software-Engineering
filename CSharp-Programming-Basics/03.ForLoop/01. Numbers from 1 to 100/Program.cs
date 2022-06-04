using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <=n; i++) // Trqbva ni druga promenliva vuv vseki edin for !!
            //{
            //    Console.WriteLine(i);// Printira ot 1 do 10 ako sme zadali n= 10 v console read line 
            //}

            for (int i = n; i >=1; i--)
            {
                Console.WriteLine(i); // Printira chislata ot console read line nadolu ako vuvedem 100 v consoleread line 100 shte ni izlezat chslata ot 100 do 1
            }
        }
    }
}