using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(1);
            //Console.WriteLine(1);
            //Console.WriteLine(1);
            //Console.WriteLine(1);
            //Console.WriteLine(1);
            //Console.WriteLine(1);
            //Console.WriteLine(1);
            //Console.WriteLine(1);
            //Console.WriteLine(1);
            //Console.WriteLine(1);

            // for (int i = 1; i<=10; i++)  // for (int i = 0; i<10; i++)
            // {
            //    Console.WriteLine(1);
            // }


            //Console.WriteLine(1);
            //Console.WriteLine(2);
            //Console.WriteLine(3);
            //Console.WriteLine(4);
            //Console.WriteLine(5);
            //Console.WriteLine(6);
            //Console.WriteLine(7);
            //Console.WriteLine(8);
            //Console.WriteLine(9);
            //Console.WriteLine(10);
 
            // for (int i = 1; i <= 10; i++)  // for (int i = 0; i<10; i++)
            // {
            //    Console.WriteLine(i);
            // }




            for (int i = 1; i <= 10; i++)  // for (int i = 0; i<10; i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine($"i={i}"); // Console.WriteLine("i=" +i)
                }
            }

            
            
            //int a = 5;
            //a += 10; // a= a+ 10 --> a = 15  Това са изчисления
            //Console.WriteLine(a);


            //int a = 5;
            //a =+10; // a = +10 --> a = 10  Това вече не са изчисления 
            //Console.WriteLine(a);

            //int a = 5;
            //a =-10; //  // a = -10 --> a = -10  Това вече не са изчисления 
            //Console.WriteLine(a);

            //int a = 5;
            //a -=10; // a = a-10 --> a = -5 Това са изчисления
            //Console.WriteLine(a);
        }
    }
}