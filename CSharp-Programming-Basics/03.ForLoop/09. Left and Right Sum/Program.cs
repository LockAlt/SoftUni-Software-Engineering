using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // 2

            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < n; i++)
            {
                leftSum = leftSum + int.Parse(Console.ReadLine()); // leftSum= leftSum +int.Parse(Console.ReadLine()). i =0 i 0<2 true --> i si izbiram primernov konzolata chisloto 5 i to stava leftSum. Pravi vtoroto vurtene i veche i = 1 --> 1<2 (1<n) i vuvejctam v Console.ReadLine 15 i stava leftSum = leftSum + ConsoleRead.Line --> 15+5 = 20 i tova e sumata
            }
            
            for (int i = 0; i < n; i++) //Posle vliza v tozi cikul i stava susthtoto kato otgore
            {
                rightSum = rightSum + int.Parse(Console.ReadLine()); // rightSum+=int.Parse(Console.ReadLine()); 
            }
             
            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                int diff = Math.Abs(rightSum - leftSum);
                Console.WriteLine($"No, diff = {diff}" );
            }
        }
    }
}