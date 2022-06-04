using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int hour = 0; hour <= 23; hour++) // Ot tuk ako e true vliza dolu v drugiq for cikul // Tozi cikul izchakva dolniq cikal i posle se vrushta otnovo tuk kato dolniq svurshi( stane false) i ako tuk oshte e true  posle pak vliza otdolu i t.n. 
            {
                for (int min = 0; min <= 59; min++)
                {
                    Console.WriteLine($"{hour:d2}:{min:d2}"); // Tova d2 slaga 0 pred chisloto kogato chisloto ne e s dve cifri kato primerno 23:1 => 23:01 ili 2:15 => 02.15

                    // Console.WriteLine($"{hour:d3}:{min:d3}"); // Ako slojim d3 proverqva dali chisloto ima 3 cifri ako ima primerno dve cifri slaga edna nula ako ima edna cifra slaga dve nuli // PROBVAI !!

                    
                    
                    //if (min < 10 && hour < 10)
                    //{
                    //    Console.WriteLine($"0{hour}:0{min}");
                    //}
                    //else if (min < 10)
                    //{
                    //    Console.WriteLine($"{hour}:0{min}");
                    //}
                    //else if (hour < 10)
                    //{
                    //    Console.WriteLine($"0{hour}:{min}");
                    //}
                    //else
                    //    Console.WriteLine($"{hour}:{min}");

                    // Moje i taka 
                }

               
            }
        }
    }
}