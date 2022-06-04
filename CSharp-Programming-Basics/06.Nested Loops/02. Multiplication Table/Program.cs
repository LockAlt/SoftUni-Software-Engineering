using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int num1 = 1; num1 <= 10; num1++) // Когато имаме вложен цикъл имаме за всяка итерация на външния цикъл имаме по n на брой итерации на вътрешния тоест сега за всяка итерация на този имаме по 10 итерации на вътрешния цикъл или общо ще имаме 100 итерации ( 10 външни * 10 вътрешни)
            {
                for (int num2 = 1; num2 <=10; num2++)
                {
                    Console.WriteLine($"{num1} * {num2} = {num1*num2}"); // 1 *1 = 1  posle stava 1*2 = 2 i tn. dokato ne stane 1*10 = 10 i posle num1 stava i++ (1++) koeto e 2 vliza v tozi for cikal i stava 2*1 = 2 i tn. otnovo i otnovo dokato ne stane 10*10 = 100                     
                    // Console.WriteLine(num1); =>  Interesno e PROBVAI !
                }
            }
        }
    }
}