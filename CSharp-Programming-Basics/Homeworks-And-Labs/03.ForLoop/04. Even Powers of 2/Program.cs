using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //for (int power = 0; power <= n; power++) //CTRL +R+R primenuvame promenlivata
            //{
            //    if (power % 2 == 0) // za da e chetna stepenta 
            //    {
            //        Console.WriteLine(Math.Pow(2, power)); // 2 na stepen power Math.Pow ti e za stepeni // 2 na stepen power !!!
            //    }
            //}
            for (int power = 0; power <= n; power += 2)  // vij tozi red 
            {
                {
                    Console.WriteLine(Math.Pow(2, power)); // Tova ti e kato gornoto samo che bez if  
                }
            }
        }
    }
}