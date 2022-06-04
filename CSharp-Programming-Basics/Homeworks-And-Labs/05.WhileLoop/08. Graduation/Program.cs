using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string name = Console.ReadLine();
            
            int grade = 1; // класът в който се намира ученика 
            double sum = 0;
            int counter = 0; // Отброява колко пъти ученикът е бил скъсан 

            while (grade <= 12) // (grade < 13)
            {
                double yearlyGrade = double.Parse(Console.ReadLine()); // оценката за годината от 1 до 12 клас
                if (yearlyGrade<4)
                {
                    if (counter==1)
                    {
                        break;
                    }
                    counter++;
                    continue; // Искаме ученикът да си остане в същия клас и да не му се смята към общата сума на класовете нито да му се вдига класът( да премине в следващия подред клас)
                }
                sum += yearlyGrade;
                grade++;
            }
            double avarageGrade = sum / 12; // Може и така sum = sum / 12; но така е по четимо като имаме променлива друга

            if (grade > 12)
            {
            Console.WriteLine($"{name} graduated. Average grade: {avarageGrade:f2}");
            }
            else
            {
                Console.WriteLine($"{name} has been excluded at {grade} grade");
            }
        }
    }
}