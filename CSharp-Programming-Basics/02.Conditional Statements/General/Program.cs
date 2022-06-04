using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(5 < 6); True
            //Console.WriteLine(5==6); False
            //Console.WriteLine(5<=6); True
            //Console.WriteLine(5 <= 6.5); True
            //Console.WriteLine("softuni"== "Softuni"); False (ima golqmo i malko S)

            //Console.WriteLine("softuni is the best" > "softuni");
            //ne stava( nqma na kakvo da gi sveri)

            //Console.WriteLine("softuni is the best" != "softuni"); True( razlichni sa)

            //int age = int.Parse(Console.ReadLine());
            //bool isOfAge = age >= 18;
            //Console.WriteLine(isOfAge);

            //int a = 5;
            //bool isPositive = a > 0; // ili e true ili e false. v tozi sluchai e True.

            //if (isPositive)
            // {
            //    Console.WriteLine("The number is positive"); // Tova shte ni izleze zashtoto bool e true
            // }

            //int a = -5;
            //bool isPositive = a > 0; //// ili e true ili e false. v tozi sluchai e False.
            //if (isPositive)
            // {
            //    Console.WriteLine("The number is positive");// Tova nqma da izleze zashtoto e negative. 
            // }

            // Moje i taka ama s bool e po-chetimo

            //int age = 39;
            //if (age >= 18)
            //{
            //    Console.WriteLine("You can drink beer!"); 
            //}

            //    int a = -5
            //    bool isNegative = a<0;
            //    if (isNegative )
            // {
            //    Console.WriteLine("The number is negative"); // Tova shte se izpishe zashtoto chishloto e negative ili a<0 e true za stoinostta na a= -5
            // }

            // double num = 5.67000789;
            //    Console.WriteLine($"{num:F4}"); // Tova F4 oznachava F(formatirai), a 4 oznachava do 4 cifri sled zapetaqta.
            //    Console.WriteLine($"{Math.Round ( num ,4)}"); // Tova Round ne smqta che 0 e neshto znachitelno i q izpuska.


            // string weather = Console.ReadLine(); //sunny,cloudy,rainy

            // if (weather == "sunny") // Ako napisha v konsolata Sunny nqma da mi izleze nishto zashtoto sunny e s malko 's'
            // {
            //    Console.WriteLine("Go for a walk!");
            // }
            // else if (weather == "cloudy") // Imame kavichki zashtoto tova e string a ne int ili double !
            // {
            //    Console.WriteLine("Take an umbrella!");
            // }
            // else if (weather == "rainy")
            // {
            //    Console.WriteLine("Stay at home!"); // Else if se izpolzva pri neshto koeto ako e napisano primerno sunny da ne proverqva drugite if i kato cqlo else if svurzva v edna oshta proverka 
            // }


            // double salary = 0;
            // string currentDay = "Monday";
            // if (currentDay== "Monday")
            // {
            //    salary = double.Parse(Console.ReadLine());
            // }
            // Console.WriteLine(salary);
        }
    }
}