using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int numberOfGrups = int.Parse(Console.ReadLine());
            
            //Със сигурност с double ги правиш заради смятането с процентите !!!
            double q1 = 0; 
            double q2 = 0;
            double q3 = 0;
            double q4 = 0;
            double q5 = 0;

            for (int i = 1; i <= numberOfGrups; i++)
            {
                int numOfPeople = int.Parse(Console.ReadLine());
                if (numOfPeople<= 5)
                {
                    q1 += numOfPeople;
                }
              else if(numOfPeople <= 12)
                {
                    q2 += numOfPeople;
                }
               else if(numOfPeople <= 25)
                {
                    q3 += numOfPeople;
                }
               else if(numOfPeople <= 40)
                {
                    q4 += numOfPeople;
                }
                else 
                {
                    q5 += numOfPeople;
                }

            }
            
            double AllPeople = q1 + q2 + q3 + q4 + q5;

            q1 = q1 / AllPeople * 100.0;
            q2 = q2 / AllPeople * 100.0;
            q3 = q3 / AllPeople * 100.0;
            q4 = q4 / AllPeople * 100.0;
            q5 = q5 / AllPeople * 100.0;

            Console.WriteLine($"{q1:f2}%");
            Console.WriteLine($"{q2:f2}%");
            Console.WriteLine($"{q3:f2}%");
            Console.WriteLine($"{q4:f2}%");
            Console.WriteLine($"{q5:f2}%");
        }
    }
}