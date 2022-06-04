using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. запазим Броя на позволени незадоволителни оценки ( незадоволителна оценка <= 4 )
            int failedTimes = int.Parse(Console.ReadLine()); 

            //2.създаваме си няколко променливи : сборът на вс оценки, броят на вс. задачи , текущото име на задача , оценка от текущата задача, counter за незадоволителните оценки които е получил в момента
            double gradeSum = 0; // сборът на вс оценки
            int gradeCount = 0; // броят на вс. оценки / задачи 
            string lastExcersice = string.Empty; // текущото име на задача / име последната задача 
            int grade = 0; //  оценка от текущата задача 
            int failedCounter = 0; // counter за незадоволителните оценки 

            //3. създаваме while цикъл и продължава докато не получим "Enough" или докато  counter за незадоволителните оценки ==  failedTimes
            // При всяко въртене на цикъла ние четем два входа :
            //=> Име на задача - текст (низ)
            //=> Оценка -цяло число в интервала[2…6]
            
            string input = Console.ReadLine(); // Името на задача 

            while (input != "Enough")
            {
                lastExcersice = input; 
                grade = int.Parse(Console.ReadLine()); // Може и директно тук да се направи тази променлива обаче не е препорачително int grade = int.Parse(Console.ReadLine())

                gradeSum += grade;
                gradeCount++;
                if (grade<=4) //Проверяваме дали оценката е незадоволителна 
                {
                    failedCounter++;
                    if (failedCounter==failedTimes)
                    {
                        Console.WriteLine($"You need a break, {failedCounter} poor grades."); // Може и така  Console.WriteLine($"You need a break, {failedTimes} poor grades.");
                        break;
                    }
                }
                input = Console.ReadLine(); // Ако не влезе в този if прочитаме ново име на input ( нова задача или Enough) 
            }

            //4. Трябва да отпечатаме изход според исловието
            double avarageScore = gradeSum / gradeCount;
            
            if (failedCounter!=failedTimes) // Ako не е стигнал броя на незадоволителните оценки 
            {
                Console.WriteLine($"Average score: {avarageScore:f2}"); // => сбор на всички оценки разделен на броят на вс оценки
                Console.WriteLine($"Number of problems: {gradeCount}");
                Console.WriteLine($"Last problem: {lastExcersice}");
            }
           
        }
    }
}