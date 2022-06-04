﻿using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // колко числа на нов ред ще получим от потребителя 

            // групи на числа според това в кой интервал се намират 
            double p1 = 0; //броя на числата в интервал от 0 до 199
            double p2 = 0; //броя на числата в интервал от 200 до 399
            double p3 = 0; //броя на числата в интервал от 400 до 599
            double p4 = 0; //броя на числата в интервал от 600 до 799
            double p5 = 0; //броя на числата равни или над 800

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case > 0 and <= 199:
                        p1++; // Увеличаваме p1 с единица защото записваме колко числа се отнасят в всяка категория примерно ако имаме 5 то влиза тук и вече имаме едно число в p1 и така на всяка обиколка се прави във всяка една от групите 
                        break;
                    case <= 399:
                        p2++; // p2++ = p2+=1 = p2 = p2 +1
                        break;
                    case <= 599:
                        p3++;
                        break;
                    case <= 799:
                        p4++;
                        break;
                    default:
                        p5++;
                        break;
                }
            }

            p1 = p1 / n * 100; // Взимаме броя на числата в съответния диапазон разделяме го на общия брой числа и го умножаваме по 100 за да го превърнем в процент // Примерно имаме че числата в p1 са 3 на брой а ние сме въвели общо 9 числа (n = 9) следователно p1 = 3/9 *100
            p2 = p2 / n * 100;
            p3 = p3 / n * 100;
            p4 = p4 / n * 100;
            p5 = p5 / n * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}