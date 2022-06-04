using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            //когато i е четно  --> i%2 == 0  => играчка 
            // (2-> 10, 4-> 20, 6-> 30...и т.н.). => 10/2 =5; 20/4 = 5; 30/6 = 5; 50/8 = 5; (сумата която тя получава е нейната възраст *5 ) и брат  й и  взима по 1 лев на всеки четен рожден  =>  i*5 -1 

            //когато i е нечетно --> i%2 != 0 => играчка на стойност toyPrice(от console)
            double moneySaved = 0;// първо парита са й 0 и постепенно се трупат
            
            for (int i = 1; i <= age; i++) // от първия до последния и рожден ден като преминаваме през всеки рожден ден и сега слагаме if за четен или нечетен рожден ден 
            {
                if (i%2==0) //  нечетен рожден ден
                {
                    moneySaved += i * 5 - 1; // moneySaved = moneySaved + i * 5 - 1 // не става moneySaved+= 10 -1 защото с всеки рожден ден и се увеличават с 10 лв от предишният 2 год - 10 лева , 4 - 20 лв. и тн.
                }
                else //  нечетен рожден ден
                {
                    moneySaved += toyPrice; // играчката има една и съща стойност и през годините се добавят общата стойност на вс играчки
                }
            }
            if (moneySaved>=washingMachinePrice)
            {
                Console.WriteLine($"Yes! {moneySaved-washingMachinePrice:F2}");
            }
            else
            {
                Console.WriteLine($"No! {washingMachinePrice-moneySaved:F2}");
            }
        }
    }
}