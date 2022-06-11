using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //• 0 - 2 – baby
            //•	3 - 13 – child
            //•	14 - 19 – teenager
            //•	20 - 65 – adult
            //•	>= 66 – elder

            //•	All the values are inclusive.

            // ВИЖ DEМО ПЪРВО  // Чрез ? задаваме въшрос към bool-а  ( age > 0 && age <= 2- боол ) 
            int age = int.Parse(Console.ReadLine());
            string result = age >= 0 && age <= 2 ? "baby" : //  Проверява дали age > 0 && age <= 2 е true or false. Ако е true отпечатва "baby" ако е false минава към двете точки , което е false продължението, а именно нова проверка ( като в else if ) 
                age > 2 && age <= 13 ? "child" : // тук вече е в false продължението и проверява дали age > 2 && age <= 13 и ако е true отпечатва "child", ако е false преминава към следващото 
                age > 13 && age <= 19 ? "teenager" : // тук е същата работа 
                age > 19 && age <= 65 ? "adult" : // и накрая тук проверява дали  age > 19 && age <= 65 е true или false, ако е true отпечатва "adult" ако не минава към вете точки (:),(else) и отпечатва "elder"
                "elder";
            Console.WriteLine(result);

            // Еднакви са решенията горе и долу
           
            
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine(age >= 0 && age <= 2 ? "baby" : 
            //    age > 2 && age <= 13 ? "child" : 
            //    age > 13 && age <= 19 ? "teenager" : 
            //    age > 19 && age <= 65 ? "adult" :
            //    "elder");



        }
    }
}
