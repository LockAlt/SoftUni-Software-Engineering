using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <=n; i+=3) // i+=3 zashtoto dobavqme 3 sled vsqko chislo
            //{
            //    Console.WriteLine(i);
            //}
            for (double i  = 1;i<=n; i+=2.5) // trqbva tuk da e double za da 2.5
            {
                Console.WriteLine(i);
            }
        }
    }
}