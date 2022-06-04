using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // n=5 

            for (int i = n; i >=1; i--) //  i =5  --> i>=5 True --> cw(i) --> cw(5) ; i-- --> i=5 - 1= 4 --> 4>=1 True --> cw(4)  
            {
                Console.WriteLine(i); // Ako bqh napravil cw(n); shteshe da mi se printi samo 5 ili tova chislo koeto sam vavel v consolereadline
            }
        }
    }
}