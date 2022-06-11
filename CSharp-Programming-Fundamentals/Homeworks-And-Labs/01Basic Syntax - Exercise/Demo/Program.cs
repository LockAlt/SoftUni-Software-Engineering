using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// ТЕРНАРЕР ОПЕРАТОР !
            //int age = int.Parse(Console.ReadLine());
            //string result = age <= 2 ? "baby" : "bigger than baby"; // Първо проверяваме дали age <= 2 и то е като bool дали е true или false и точно въпреосителния знак(?) го проверява и ако  age <= 2 е true първото нещо отдясно на въпреосителния знак(?) е резултата и се изписва той("baby"),
            //                                                        // после имаме все едно else ( ако не е вярно  age <= 2), да се изпише "bigger than baby" и това else се определя след като сме сложили резултата на true сложим две точки (:) и след тях е резултата от false
            //Console.WriteLine(result);



            //// Двете неща отгоре и отдолу правят едно и също !



            //if (age <= 2)
            //{
            //    Console.WriteLine("baby");
            //}
            //else
            //{
            //    Console.WriteLine("bigger than baby");
            //}


            //// Двете неща отгоре и отдолу правят едно и също !

            //    int age = int.Parse(Console.ReadLine());
            //    Console.WriteLine(age<=2 ? "baby" : "bigger than baby");
            
            
            
            
            
            //Console.WriteLine("1");
            //Console.Write("2");
            //Console.Write("3");
            //Console.WriteLine("4");
            //Console.WriteLine("5");
            //Console.Write("6");
           
            ////1
            ////234 
            ////5
            ////6    
            
            //// Така ще изглежда конзолата ! 



            string username = Console.ReadLine();
            for (int i = 0; i < username.Length; i++)
            {
                Console.WriteLine(username[i]);
            }

            // pesho - Input

            // p - 0
            // e - 1
            // s - 2
            // h - 3
            // o - 4

            // Output 

        }
    }
}
