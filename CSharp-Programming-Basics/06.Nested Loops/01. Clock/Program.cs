using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int hour = 0; hour <= 23; hour++) // Ot tuk ako e true vliza dolu v drugiq for cikul // Tozi cikul izchakva dolniq cikal i posle se vrushta otnovo tuk ako tuk oshte e true i posle pak vliza otdolu i t.n. 
            {
                for (int min = 0; min <= 59; min++)
                {
                    //if (min==5)
                    //{
                    //    break;
                    //}
                    
                    // Виж как ще работи с двете( не едновременно)
                    
                    //if (min==5)
                    //{
                    //    continue;
                    //}
                    Console.WriteLine($"{hour}:{min}");

                    // КОГАТО ИМАМЕ ВЛОЖЕНИ ЦИКЛИ ПРАВИМ КОМБИНАЦИИ ОТ ЧИСЛА ПРИМЕРНО ТУК ПРАВИМ ВСИЧКИ ВЪЗМОЖНИ КОМБИНАЦИИ НА ВСЕКИ ЧАС С ВСЯКА МИНУТА
                }
            }
        }
    }
}