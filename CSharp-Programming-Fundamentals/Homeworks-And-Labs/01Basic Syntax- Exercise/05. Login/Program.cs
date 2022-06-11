using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine(); // pesho => pesho.Lenght = 5 
            string password = ""; // Паролата е username на обратно // Може и със   string password = string.Empty;

            // p-0, e-1, s-2, h-3, o-4 -> char символите на коят буква отговарят  // Казват се array и започват да се броят от 0 затова са с 1 по-малко от .Lenght
            // username[0] -> p , username[1] -> e и тн.
            int uresenrameLenght = username.Length - 1; // За да може да почне с един символ надолу,защото както отгоре съм написал символите са с едно по-малко от дължината на думата 
            
            for (int i = uresenrameLenght; i >= 0; i--)  // Така ще може да ни изкара думата отзад напред
            {
                password += username[i]; //  password += i -> ако беше така щяха само цифрите да излезнат на един ред         // Console.WriteLine(username[i]); -> така го прави всяко на отделен ред 
            }

            int countOfWrongPasswords = 0;
            string inputPassoword= Console.ReadLine(); // Това е паролата, която потребителя въвежда докато не познае истинския password
            while (inputPassoword!=password)
            {
                countOfWrongPasswords++;
                if (countOfWrongPasswords>3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return; // Директно спира програмата не само цикъла с break
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                    inputPassoword = Console.ReadLine(); // Тук въвеждаме нова парола и се връща в началото на while цикъла да провери дали (inputPassoword!=password)
                }
            }

            if (inputPassoword == password) // Това е най-отдолу защото, ако паролата е вярна няма изобщо да влезне в while цикъла
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}