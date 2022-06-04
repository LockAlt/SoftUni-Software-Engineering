using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int start = int.Parse(Console.ReadLine()); // 1
            int end = int.Parse(Console.ReadLine()); // 3

            int magicNum= int.Parse(Console.ReadLine());

            int counter = 0; // брояч на колко комбинации имаме 

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    // 1 1  // 1 2   // 1 3  // 2 1  // 2 2   // 2 3  // 3 1  // 3 2  // 3 3
                    counter++;

                    if (i + j == magicNum)
                    {
                        Console.WriteLine($"Combination N:{counter} ({i} + {j} = {magicNum})");
                        return; // Environment.Exit(0) // НЕ ТРЯБВА ДА ОТПЕЧАТВАМЕ ВСЯКА КОМБИНАЦИЯ КОЯТО СТАВА А КОГАТО ИМАМЕ ТАКАВА ТРЯБВА ДА ОТПЕЧАТВАМЕ САМО ПЪРВАТА ЗАТОВА СЛАГАМЕ RETURN ДА СПИРА ПРОГРАМАТА КОГАТО НАМЕРИ КОМБИНАЦИЯ И Я ИЗПИШЕ 
                    }
                    //else // Не се прави в цикъла защото става безкрайно спамене 
                    //{
                    //    Console.WriteLine($"{counter} combinations - neither equals {magicNum}");
                    //}
                }
            }
            Console.WriteLine($"{counter} combinations - neither equals {magicNum}"); // Слагаме го тук защото ако това не е станало true if (i + j == magicNum) няма изобщо да има return следователно ще сме излезнали от  циклите които ще са свършили когато са проверили вс. комбинации 

        }
    }
}