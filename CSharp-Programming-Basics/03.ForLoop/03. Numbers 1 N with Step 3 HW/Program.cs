using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine()); // 7

            for (int i = 1; i <= n; i+=3) // i= 1 ; i<=7 ; i+=3 --> i=1 --> 1<=7 true --> cw(i) --> cw(1) -----> vtorata brutka i+=3 --> 1+=3 --> i=4--> 4<=7 true--> cw(4)--->treta vrutka 4+=3 i=7 --> 7<=7 true => cw(7)
            {
                Console.WriteLine(i);
            }

        }
    }
}