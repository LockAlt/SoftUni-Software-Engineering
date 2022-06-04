using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string input; // !!!!
            //for (int i = 1; i <= 10; i++) // i=2   --> i=3
            //{
            //  input = Console.ReadLine(); // Въвежда се No  (отделни завъртания)   --> после се пише число 2 
            //    if (input=="No")// влиза тук     (отделни завъртания)    -- >  пропуска го това 
            //    {
            //        continue;
            //    }

            //    int num = int.Parse(input); // Пропуска тази част и се връща отгоре като следващо завъртане на цикъла като вече е i=3   (отделни завъртания) -- >  и вече от "2" става на 2 
            //    Console.WriteLine(num*2); // и се смята 2*2 което е 4 и тн.
            //}


            //string input; // !!!!
            //for (int i = 1; i <= 10; i++)  //въвеждат се числа и се смятат и в момента в който се въведе  No влиза в If и for цикъла спира !
            //{
            //    input = Console.ReadLine(); 
            //    if (input == "No")
            //    {
            //        break;
            //    }

            //    int num = int.Parse(input);  
            //    Console.WriteLine(num * 2); 
            //}

            Console.WriteLine("Следващo упражнение!");


            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("-------------------------------------"); // Това от горе и отдолу са еднакви !

            //int j = 1;
            //while (j <= 10) // Докато j <= 10 е True  да принтира j // НЕ МОЖЕ while (j <= 10;j++) защото това вече не е условие // WhILE УСЛОВИЯТА ФУНКЦИОНИРАТ ПОДОБНО КАТО IF УСЛОВИЯТА !!
            //{

            //    Console.WriteLine(j);
            //    j++; // Това трябва да го имаме иначе ще стане безкраен цикъл
            //}




            Console.WriteLine("Следващo упражнение!");

            //// Дебъгни !
            //string input = Console.ReadLine();//ако string input = string.Empty; ще е празно и ще тръгне от j = 1; и ще го принтира и после ще ние даде да пишем стойност за input иначе като string input = Console.ReadLine(); ни дава възможност да напишем каквото искаме и тн. първоначално
            //int j = 1;
            //while (input !="Stop") // Докато input !="Stop" e True  да принтира j
            //{

            //    Console.WriteLine("j = " +j);
            //    j++; // Това трябва да го имаме иначе ще стане безкраен цикъл
            //    input = Console.ReadLine(); // !!!
            //}




            // for - когато знаем каква ще е първоначалната и крайната стойност на цикъла(знаем колко пъти трябва да се завърти)  
            // while - . Примерено със задачите с пресмятането на числа и по някое време да се каже стоп и да спре това може да го прави САМО while цикъла ! 

            Console.WriteLine("Следващo упражнение!");

            int counter = 0;
            while (true) // Ako e false избощо няма да се изпълни  този код 
            {
                counter++;
                    Console.WriteLine(counter);
                if (counter==10)
                {
                    break;
                }
            }
            
        }
    }
}