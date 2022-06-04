using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string username = Console.ReadLine();
            string password = Console.ReadLine();

            int attempts = 0;

            string passwordAttempt = Console.ReadLine();


            while (passwordAttempt != password) // Ако това условие е false то не влиза в този while цикъл ( passwordAttempt == password) ако това е вярно следва че passwordAttempt != password е false
            {
                attempts++;  // Това го слагаме тук защото ако е влезнало в този while цикъл вече явно сме написли грешна парола и това става един опит 

                if (attempts == 3)
                {
                    break; // Спира изпълнението на while цикъла (директно излиза от while) 
                }
                passwordAttempt = Console.ReadLine();
            }

            if (passwordAttempt == password)
            {
                Console.WriteLine($"Welcome {username}!");
                // break; !!!НЕ МОЖЕ 
            }

        }
    }
}