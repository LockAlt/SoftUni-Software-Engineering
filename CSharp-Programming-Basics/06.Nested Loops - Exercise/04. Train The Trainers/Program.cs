using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  броя на журито => n = int.Parse(Console.ReadLine()); n ( журито)
            int n = int.Parse(Console.ReadLine());
            // входът от конзолата  - input (презентациите или finish)
            string input = Console.ReadLine();
            // сбора на вс оценки на моментната презентация 
            double presentationSum= 0; 
            //  броя на вс презентации
            int presentationNum = 0; 
            //сборът от средните оценки за всяка от презентациите
            double sum = 0;

            
            
            // четем имена на презентации ,докато не получим input = "finish"
            // => while (input!= "finish")
            
            while (input != "Finish")
            {

                presentationSum = 0; // Нулираме сборът от оценките за да може на следващите вартения на цикъла да се смятат правилно
                //=> всеки един от журито трябва да даде оцени  презентацията -> ще се добавя към personalPresentaionSum
                // => for цикъл от i = 1  до i<=n  ( от първия от журито до последния )
                for (int i = 1; i <= n; i++)
                {
                    //=>(това е в цикъла)всеки един от журито ще даде оценка на текущата презентация  => трябва тази оценка да я добавим като сбор на вс. оценки на конкретната презентация
                     presentationSum += double.Parse(Console.ReadLine());             
                }

                //намира средна оценка(personalAvarageSum) =>  PresentaionSum/n
                double avarageSumOfOnePresentation = presentationSum / n; // средната оценка на една презентация
                //трябва да я добавим към сбора на вс. средни оценки sum+= PresentaionSum
                sum += avarageSumOfOnePresentation;
                // =>  Отпечатваме: "{името на презентацията} - {средна оценка}."
                Console.WriteLine($"{input} - {avarageSumOfOnePresentation:f2}.");
                //=> presentationNum++ // тези операции отгоре се случват за всяка презентация следователно тук си учвеличаваме номера на всяка изминала презентация
                presentationNum++;
                //=> четем нов вход (input) (име на презентацията)
                input = Console.ReadLine();
                
                
            }
            //излизаме от цикъла 
            // среден успех от всички презентации => sum/ presentationNum
            double avargeSumOfAllPresentations = sum / presentationNum;
            // след като получим  input = "finish" излизаме от  while цикъла  и отпечатваме "Student's final assessment is {среден успех от всички презентации}." 
            Console.WriteLine($"Student's final assessment is {avargeSumOfAllPresentations:f2}."); 
        }
    }
}