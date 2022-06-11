using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Account Credentials : истинската парола и усернаме 
            string username = Console.ReadLine();
            string password = Console.ReadLine();

           string passwordAttempt = Console.ReadLine();
           
            while (password != password)
            {
               passwordAttempt = Console.ReadLine(); // Караме го да въведе нова парола ( нов опит) и когато password != password стане false(когато стане false означава че password == password) и излизаме от while цикъла   
            }
            Console.WriteLine($"Welcome {username}!");
        }
    }
}