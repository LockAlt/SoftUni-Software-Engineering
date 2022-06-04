using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double strawberriesPrice = double.Parse(Console.ReadLine());

            double bananasQuantity = double.Parse(Console.ReadLine());
            double orangesQuanity = double.Parse(Console.ReadLine());
            double raspberryQuantity = double.Parse(Console.ReadLine());
            double strawberriesQuantity = double.Parse(Console.ReadLine());

            double raspberryPrice = strawberriesPrice / 2;
            //strawberriesPrice => получаваме от кнозолата 
            //raspberriesPrice => strawberriesPrice/2
            //orangePrice => rasraspberriesPrice - raspberriesPrice*40/100 може и така( rasraspberriesPrice*60/100) 
            //bananasPrice =>rasraspberriesPrice - raspberriesPrice*80/100 може и така ( rasraspberriesPrice*20/100) 

            

            double strawberry = strawberriesPrice * strawberriesQuantity;
            double raspberry = raspberryPrice * raspberryQuantity;
            double oranges = (raspberryPrice - (raspberryPrice * 40 / 100)) * orangesQuanity;
            double bananas = (raspberryPrice - (raspberryPrice * 80 / 100)) * bananasQuantity;
            Console.WriteLine($"{strawberry+raspberry+oranges+bananas:f2}");

            
        }
    }
}