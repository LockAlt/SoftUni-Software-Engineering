using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            int tabsOpened = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            // ТАЗИ ЗАДАЧА Е НАПРАВЕНА БЕЗ ПРОМЕНЛИВАТА PENALY = 0; !!!!
            
            //•	"Facebook"-> 150 лв.
            //•	"Instagram"-> 100 лв.
            //•	"Reddit"-> 50 лв.


            for (int i = 1; i <= tabsOpened; i++) // Започваме от първия таб до последния включително
            {
                string site = Console.ReadLine();
                if (site == "Facebook")
                {
                   salary -= 150; //  int penalty = 0; penalty += 150;  Това трябваше да пишем на всякъде ако я нямахме горната променлива -->  int penalty = 0;
                }
                else if (site == "Instagram")
                {
                    salary -= 100;
                }
                else if (site == "Reddit")
                {
                    salary -= 50;
                }
                else  // този else = else if( site != "Facebook"&& site != "Instagram" && site != "Reddit") // Това е за всички останали сайтове
                {
                    salary = salary - 0; // Ако е  penalty = 0 ще стане като в миналата задача примерно ако е penalty=150 и поле влезе на следващата въртка тук  да се рефрешне и да стане  penalty =0
                }

                if (salary<=0) // слагаме го в for цикъла защото на всяко изчисление трябва да се провери дали заплтата му е станала по-малка или равна на глобите(= глобата му е станала по-голяма или равна на заплатата) // и следователно ако penalty>=salary e True влиза вътре изписва го и for цикъла свършва
                {
                    Console.WriteLine("You have lost your salary.");
                    break; // Това служи за спиране на for цикъла дотам докъдето е стигнал и продължава надолу( извън for цикъла) ако има следващи изчисления и тн.
                }
            }

            if (salary > 0)
            {
                Console.WriteLine(salary);
            }
        }
    }
}