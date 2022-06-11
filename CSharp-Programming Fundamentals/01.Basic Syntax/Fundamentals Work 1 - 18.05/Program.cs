using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grade = 5.5334;
            int percentage = 55;
            Console.WriteLine("{0:F2}", grade);      // 5.53
            Console.WriteLine("{0:D3}", percentage); // 055 // Само за int става // Ако цифрата ила два знака например 93 и ние напишем D2 ще изпише 93, защото числото вече има два знака 

            Console.WriteLine("");
            Console.WriteLine("NEXT EXAMPLE");



            Console.WriteLine("");
            Console.WriteLine("NEXT EXAMPLE");

            double pet = 5.5334;
            int am = 55;
            Console.WriteLine("{0:F1}", pet);// 5.5
            Console.WriteLine("{0:D6}", am); // 000055


            int a = 5;
            int b = 10;

            Console.WriteLine("");
            Console.WriteLine("NEXT EXAMPLE");

            Console.WriteLine(a < b);
            Console.WriteLine("a < b");
            Console.WriteLine($"{a} < {b}");

            // Ctrl + D - копира сегашния ред на следващия

            int g = 5;
               // Със do while цикъла си гарантираме поне едно изпълняване на командата,
                // защото примерно g = 5 първо влиза в do принтира го след това го увеличава и после проверява в while дали g>10 и излиза че 6 не е по-голямо от 10 следователно спира цикъла 
              do
                {
                Console.WriteLine(g);
                g++;
                }            
              while (g>10);
           
            // Със F5 преминаваме от един break point към друг след като сме пуснали debug
        }
    }
}