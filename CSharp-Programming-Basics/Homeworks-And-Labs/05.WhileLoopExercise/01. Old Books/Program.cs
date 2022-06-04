using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //запазваме любимата книга на Ани
            //създаваме цикъл в който всеки път ще четем заглавието на нова книга => докато не минем през вс. книги ( докато не получим текста No More Books) или докато не намерим любимата книга 
            //принтираме отговора ако сме или ако не сме я намерили 


            string favouriteBook = Console.ReadLine();
            int counter = 0; // броя на книгите през които сме преминали в търсенето на любимата
            string input = Console.ReadLine();


            while (input !="No More Books")
            {
                if (input==favouriteBook)
                {
                    // Console.WriteLine($"You checked {counter} books and found it."); // Може и тук да се сложи и накрая вместо най-отдолу да имаме if и else само да имаме if за No More Books 
                    break; 
                }
                counter++; // Проверява колко пъти се е изпълнил цикъла 
                input = Console.ReadLine();

            }
            if (input==favouriteBook)
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }
        }
    }
}