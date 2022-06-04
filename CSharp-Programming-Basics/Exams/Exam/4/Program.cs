using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            //double studentGrade = double.Parse(Console.ReadLine());
            double studentGrade = 0;

            double student1 = 0;
            double student2 = 0;
            double student3 = 0;
            double student4 = 0;

            double Group1 = 0;
            double Group2 = 0;
            double Group3 = 0;
            double Group4 = 0;

            double studentsFullGrades = 0;

            double avarageSuccess = 0;

            for (int i = 1; i <= numberOfStudents; i++)
            {
                studentGrade = double.Parse(Console.ReadLine());
                if (studentGrade >= 5.00)
                {
                    student1++;
                }
                else if (studentGrade >= 4 && studentGrade <= 4.99)
                {
                    student2++;
                }
                else if (studentGrade >= 3 && studentGrade <= 3.99)
                {
                    student3++;
                }
                else
                {
                    student4++;
                }
                studentsFullGrades += studentGrade;

            }
            Group1 = student1 / numberOfStudents * 100;
            Group2 = student2 / numberOfStudents * 100;
            Group3 = student3 / numberOfStudents * 100;
            Group4 = student4 / numberOfStudents * 100;

            avarageSuccess = studentsFullGrades / numberOfStudents;

            Console.WriteLine($"Top students: {Group1:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {Group2:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {Group3:f2}%");
            Console.WriteLine($"Fail: {Group4:f2}%");
            Console.WriteLine($"Average: {avarageSuccess:f2}");

        }
    }
}