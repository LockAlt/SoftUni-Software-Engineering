
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //          Friday  Saturday    Sunday
            //Students    8.45     9.80      10.46
            //Business    10.90   15.60       16
            //Regular      15      20        22.50

            //For Students – if the group is 30 or more people, you should reduce the total price by 15 %.
            //For Business – if the group is 100 or more people, 10 of the people stay for free.
           //For Regular – if the group is between 10 and 20  people(both inclusively), reduce the total price by 5 %.


            int peopleCount  = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string day = Console.ReadLine();
            double totalPrice = 0;

            if (typeOfGroup == "Students")
            {
                if (day == "Friday")
                {
                    totalPrice = peopleCount * 8.45;
                }
                else if (day=="Saturday")
                {
                    totalPrice = peopleCount * 9.80;
                }
                else if (day == "Sunday")
                {
                   totalPrice = peopleCount * 10.46;
                }
                if (peopleCount>=30) // ЗАДЪЛЖИТЕЛНО С if А НЕ С else if ЗАЩОТО ТАЗИ ПРОВЕРКА ТРЯБВА ДА СЕ НАПРАВИ НЕЗАВИСИМО ДАЛИ ВЛЕЗЕ В НЯКОЯ ОТ ДРУГИТЕ ПРОВЕРКИ
                {
                    totalPrice -= totalPrice * 15 / 100; // totalPrice = totalPrice - ( totalPrice * 15 / 100)
                }
            }
           else if (typeOfGroup == "Business")
            {

                if (peopleCount >= 100) // ЗАДЪЛЖИТЕЛНО С if А НЕ С else if ЗАЩОТО ТАЗИ ПРОВЕРКА ТРЯБВА ДА СЕ НАПРАВИ НЕЗАВИСИМО ДАЛИ ВЛЕЗЕ В НЯКОЯ ОТ ДРУГИТЕ ПРОВЕРКИ
                {
                    peopleCount -= 10; // peopleCount = peopleCount - 10;
                                       //  totalPrice = totalPrice - (totalPrice / peopleCount * 10);// totalPrice = 1760 - ( 1760 / 110 * 10)  // 1760 - ( 1760 * 
                }
               
                if (day == "Friday")
                {
                    totalPrice = peopleCount * 10.90;
                }
                else if (day == "Saturday")
                {
                    totalPrice = peopleCount * 15.60;
                }
                else if (day == "Sunday")
                {
                    totalPrice = peopleCount * 16; // totalPrice = 110 * 16 =1760 виж надолу 
                } 
            }
            else if (typeOfGroup == "Regular")
            {
                if (day == "Friday")
                {
                    totalPrice = peopleCount * 15;
                }
                else if (day == "Saturday")
                {
                    totalPrice = peopleCount * 20;
                }
                else if (day == "Sunday")
                {
                    totalPrice = peopleCount * 22.50;
                }
                if (peopleCount >=10 && peopleCount <=20) // ЗАДЪЛЖИТЕЛНО С if А НЕ С else if ЗАЩОТО ТАЗИ ПРОВЕРКА ТРЯБВА ДА СЕ НАПРАВИ НЕЗАВИСИМО ДАЛИ ВЛЕЗЕ В НЯКОЯ ОТ ДРУГИТЕ ПРОВЕРКИ
                {
                    
                    totalPrice -= totalPrice * 5/100;
                }
            }
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
