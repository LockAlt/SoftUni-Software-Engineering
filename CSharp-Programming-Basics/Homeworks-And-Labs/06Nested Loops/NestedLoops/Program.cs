using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //for (int hour = 0; hour <= 23; hour++)  // този цикъла чака този долу
            //{
            //    for (int min = 0; min <= 59; min++) //а пък този чака този отдолу
            //    {
            //        Console.WriteLine($"{hour:d2}:{min:d2}");

            //        if (hour == 22 && min == 30)
            //        {
            //            break; // с този break излиза само от цикъла за минутите и отива пак към цикъла с часовете като вече hour се вдига с 1 защотото имаме hour++ и си продължава така докато не стане 23.59 
            //        }
            //    }
            //}
            // ВИЖ каква е разликата м/у break и continue
            
            //for (int hour = 0; hour <= 23; hour++)  // този цикъла чака този долу
            //{
            //    for (int min = 0; min <= 59; min++) //а пък този чака този отдолу
            //    {
            //        Console.WriteLine($"{hour:d2}:{min:d2}");

            //        if (hour == 22 && min == 30)
            //        {
            //            continue; 
            //        }
            //    }
            //}

            // 3-те начина с които да излеземе от вложени цикли  !!!

            // 1. bool flag !!!!! -> помага ни да излезне от всеки цикъл един по един внимателно 

            //bool flag = false;

            //for (int hour = 0; hour <= 23; hour++)  // Този цикъла чака този долу
            //{
            //    for (int min = 0; min <= 59; min++) //А пък този чака този отдолу
            //    {
            //        Console.WriteLine($"{hour:d2}:{min:d2}");

            //        if (hour == 22 && min == 30)
            //        {
            //            flag = true;
            //            break; // Използваме  break излизаме от този цикъл и отиваме ( виж долу)
            //        }
            //    }// Отиваме тук и слиза надолу   

            //    if (flag == true) // Ето тук проверява дали flag == true и съответно долния break излиза и от най-външния цикъл
            //    {
            //        break;
            //    }
            //}

            // Имаме два вложени цикъла имаме два break ; имаме пет вложени цикъла имаме пет break!!!

            bool flag = false;
            for (int day = 1; day <= 28; day++) // Първо влиза тук деня си е 1 това е day <= 28 вярно следователно Console.WriteLine($"{day:d2}.02.2022"); и влиза в долния цикъл
            {
                Console.WriteLine($"{day:d2}.02.2022"); // Влиза тук hour = 0 и hour <= 23 е вярно следователно влиза в долния цикъл
                for (int hour = 0; hour <= 23; hour++)  
                {
                    for (int min = 0; min <= 59; min++) // Влиза тук и почва да си брои от 0 до 59 като като стане 60мин дава False
                    {
                        Console.WriteLine($"{hour:d2}:{min:d2}");

                        if (hour == 1 && min == 05) 
                        {
                            flag = true;
                            break;
                        }

                    } // След False директно влиза отдолу а не се спира на тази скоба да повтори този цикъл
                    if (flag == true) // Проверява това което сега е False и слиза надолу
                    {
                        break;
                    }
                } // Тук горния цикъл го хваща и hour++ добавя 1 и така пак влиза в минутите и като стане 1.05 флага става true излиза от цикъла с минутите и влиза в този влиза в if който вече е true излиза от цикъла с часовете и влиза с дните където става същото излизане
                if (flag == true)
                {
                    break;
                }
            }

            // Имаме 3 for следователно имаме 3 break


            //2. return; !!! -> излизаме директно от програмта докадето е стигнала

            //for (int day = 1; day <= 28; day++)
            //{
            //    Console.WriteLine($"{day:d2}.02.2022");
            //    for (int hour = 0; hour <= 23; hour++)  // Този цикъла чака този долу
            //    {
            //        for (int min = 0; min <= 59; min++) //А пък този  чака този отдолу
            //        {
            //            Console.WriteLine($"{hour:d2}:{min:d2}");
            //            if (hour == 22 && min == 30)
            //            {
            //                return; // Спира main метода ( цялата програма) до където е стигнала. 
            //            }
            //        }
            //    }
            //}
            //Console.WriteLine("Hello"); // Сега примерно когато имаме код отдолу под циъкла няма да се изпълни защото има return в единия цикъл и ще спре програмата единственият начин да не спира е ако в друга ситуалция в for циклите не влезе в if-а с return-а а си приключи нормално 



            //3. Environment.Exit(0); е същото като return

            //for (int day = 1; day <= 28; day++)
            //{
            //    Console.WriteLine($"{day:d2}.02.2022");
            //    for (int hour = 0; hour <= 23; hour++)  // Този цикъла чака този долу
            //    {
            //        for (int min = 0; min <= 59; min++) //А пък този чака този отдолу
            //        {
            //            Console.WriteLine($"{hour:d2}:{min:d2}");
            //            if (hour == 22 && min == 30)
            //            {
            //                Environment.Exit(0); // Спира main метода ( цялата програма) до където е стигнала. 
            //            }
            //        }
            //    }
            //}


            // Когато имаме комбинации от цифри или някакво генериране на числа се използва FOR цикъл
            // Когато имаме с подадени string имаме while цикъл

        }
    }
}