using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string areThereAnyDishes = Console.ReadLine(); // yes/no  // 1 най-важно в този вид цикъл

            //while (areThereAnyDishes == "yes") 
            //{
            //    Console.WriteLine("Washing a dish .."); // 2 най-важно в този вид цикъл
            //    areThereAnyDishes = Console.ReadLine(); // Проверяваме след измитата чиния дали има още чинии и когато стане No ще излезне от while цикъла защото areThereAnyDishes == "yes" ще стане False // 3 най-важно в този вид цикъл
            //}

            //while (areThereAnyDishes == "yes") 
            //{
            //    Console.WriteLine("Washing a dish ..");  // Безкраен цикъл
            //}


            //string areThereAnyDishes = Console.ReadLine();

            //if (areThereAnyDishes == "yes") // While е като if само че при while проверката се повтаря многократно докато не стане false // Дебъгни това !
            //{
            //    Console.WriteLine("Washing a dish .."); 
            //    areThereAnyDishes = Console.ReadLine();
            //}



            // int numberOfDishes = 5;

            // while (numberOfDishes > 0) // Започва от 5 вкл. ; Същото ще е логиката ако стане numberOfDishes >= 0 като отдолу или ако numberOfDishes > 1 пак е същата логика като при for 
            // {
            //    Console.WriteLine("Washing a dish....");
            //    numberOfDishes--;
            // }

            // Тези двете правят едно и също отгоре и отдолу

            //for (int i = 5; i > 0; i--) //  Започва от 5 вкл. същото е и с for (int i = 5; i >= 1; i--) ако беше  for (int i = 5; i >= 0; i--) щеше да се изпринти 6 пъти а ако   for (int i = 5; i > 1; i--) беше щеше да се изпринти 4 пъти 
            //{
            //    Console.WriteLine("Washing a dish....");
            //}

            // For е по-удобен за числа и когато имаме точно определен брой повторения, а while е когато не знаем колко пъти ще се повтори нещо


            //string username = Console.ReadLine().ToLower(); // DENIS -> denis ; Denis -> denis ; DEnis -> denis и тн.
            //Console.WriteLine(username);

            //string username = Console.ReadLine().ToUpper(); // denis -> DENIS ; Denis -> DENIS и тн.
            //Console.WriteLine(username);




            // 10
            // 20
            // 30
            // Stop
            
            string command = Console.ReadLine(); // "10"
            int sum = 0;
            
            while (command != "Stop")
            {
                sum += int.Parse(command); // command става от string в int ( "10" -> 10) // Принципно може и така sum += int.Parse("50") ако ти трябва 50 като число  и тн. каквото се подаде става от стринг в инт; // sum+= command не става защото едното е string а другото е int а с string не могат да се правят изчисления // може такива работи да се правят и с double.Parse(command),char.Parse(command) и тн.
                command = Console.ReadLine();
            }
            Console.WriteLine(sum);

            // !!!!


            // continue - използва се когато искаме да пропуснем останалата част от кода в цикъла и цикъла започва отначало със следваща обиколка смисъл връща се в скобите при while) -> while(input = "Wednesday") примерно
            // break - спира цикъла и излиза извън него и продължава надолу след цикъла //може да съществува само в for,while,switch // в if и тн. не може  !!!!!
            // return - спира main метода( програмата) 

            // string text = "";  <=> string text = String.Empty  ( това важи само за string ) при int се използва  int = 0; или както го правихме с Min.Value или Max.Value
        }
    }
}