using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //променливи за броя дни и общо количество храна 
            int days = int.Parse(Console.ReadLine());
            double food = double.Parse(Console.ReadLine());
            // някъде трябва да си пазим общото количество за кучето
            double dogFood = 0;
            // някъде трябва да си пазим общото количество за котката
            double catFood = 0;

            // общото количество бисквите които са 10% ит храната за кучето и котката за деня  (на всеки 3 ден )
            double biscuits = 0;

            // две променливи които ще пазят дневното количество храна за котката и за кучето
            double dogDailyFood;
            double catDailyFood;


            // за всеки ден =>  трябва да четем количеството храна за котката и за кучето
            // => на всеки 3 ден => бонус бисквитки, които са 10% от храната за кучето и котката за деня (от общо изядената храна за деня.)
            for (int today = 1; today <= days; today++) // for цикъл за дните 
            {
                dogDailyFood = double.Parse((Console.ReadLine()));
                catDailyFood = double.Parse((Console.ReadLine()));

                if (today % 3 == 0)
                {
                    biscuits += (dogDailyFood + catDailyFood) * 10 / 100; // директно може да разделим на 10 защото  10/100 е 1/10 
                }
                dogDailyFood += dogFood;
                catDailyFood += catFood;
            }


            //изчисляваме какът процент от цялото количество храна кучто и котката общо са изяли през всичките дни 

            // процентите = (dogFood + catFood )* 100/ food

            //какъв процент е изяло кучето от общото количество храна които са изяли на котката и кучето 
            // => dogFood *100/ (dogFood + catFood )
            //какъв процент е изяло котката от общото количество храна които са изяли на котката и кучето
            // => catFood * 100/ (dogFood + catFood )


            // ако общо храната е 20 кг
            // общо са изяли ( 10кг кучето  и 5кг котката)
            // изчисляваме какът процент от цялото количество храна за изяли през всичките дни =>  какъв процент са 15кг от общо 20 кг
            //какъв процент от  общото количество храна на котката е изяло кучето =>  10 кг от 15 кг 
            //какъв процент от общото количество храна на котката е изяла котката => 5 кг от 15 кг
             
            Console.WriteLine($"Total eaten biscuits: {Math.Round(biscuits)}gr."); //Console.WriteLine($"Total eaten biscuits: {biscuits:f0}gr."); 
            Console.WriteLine($"{(dogFood + catFood) * 100 / food:f2}% of the food has been eaten.");
            Console.WriteLine($"{dogFood * 100 / (dogFood + catFood):f2}% eaten from the dog."); 
            Console.WriteLine($"{catFood * 100 / (dogFood + catFood):f2}% eaten from the cat.");

            // Няма нужда да създаваме още променливи а просто си слагаме формулата в  Console.WriteLine
        }
    }
}