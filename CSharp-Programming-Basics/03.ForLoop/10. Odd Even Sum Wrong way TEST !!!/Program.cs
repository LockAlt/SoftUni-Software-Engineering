using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // 4
            int oddSum = 0;
            int evenSum = 0;


            for (int i = 0; i < n; i++) // 6, 5 , 4, 5
            {
                int num = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += num;
                }
                else
                {
                    oddSum += num;
                }
                // !!!!Tuk q nqma tazi skoba na for - vnimavash da si zatvoril for skobata zashtoto inache shte vliza v if sled vseki for a taka kato e zakluchena kato svurshi v for shte vleze v if

                if (evenSum == oddSum)
                {
                    Console.WriteLine("Yes");
                    Console.WriteLine("Sum = " + evenSum); //  Console.WriteLine($"Sum = {evenSum}");
                }
                else
                {
                    Console.WriteLine("No");
                    Console.WriteLine("Diff =" + Math.Abs(evenSum - oddSum)); //Console.WriteLine($"Diff = {Math.Abs(evenSum-oddSum)} ");
                }
            } // TUK E FOR SKOBATA VISH KAK DEISTVA PROGRAMATA
        }
    }
}