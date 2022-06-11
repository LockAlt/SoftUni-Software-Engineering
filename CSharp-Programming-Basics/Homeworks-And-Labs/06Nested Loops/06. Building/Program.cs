using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int floors = int.Parse(Console.ReadLine());
           int rooms = int.Parse(Console.ReadLine());


            for (int floor = floors; floor > 0 ; floor--) // Започваме от последния към най-долния етаж 
            {
                for (int room = 0; room < rooms; room++)
                {
                    if (floor == floors)
                    {
                        Console.Write($"L{floor}{room} ");
                        continue;   // За да пропуснем следващите проверки защото ще ни се добавят два апартамента защото в единия случай ще е последен етаж четен и ще имаме L и O в другия вариант ще е последен и нечетен и ще имаме A и О
                    }
                     if (floor % 2 == 0)
                    {
                        Console.Write($"O{floor}{room} "); // Console.Write  изписва всички неща на един ред 
                    }
                    else
                    {
                        Console.Write($"A{floor}{room} ");
                    }
                }
                Console.WriteLine(); // Tова го слагаме като си изреди всяка стая на определения етаж и излезе от цикъла със стаите да дойде тук и да направи празен ред 
            }

        }
    }
}