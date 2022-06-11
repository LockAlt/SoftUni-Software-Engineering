using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // трябва да си създадем променлива която да пази нашият вход - input 
            string input = Console.ReadLine();
            // трябва да имаме променлива в която ще запазваме текущото число
            int num; // В момента нямаме число затова го слагаме така без да му задава стойност
            //променливи за сумата на простите числа  - primeSum
            int primeSum = 0;
            //променливи за сумата на НЕпростите числа - nonPrimeSum
            int nonPrimeSum = 0;
            // цикъл , който да се върти докато не получим input = "stop"
            // while( input !="stop")
            while (input!="stop")
            {
                //преобразуваме нашия input в число => num= int.Parse(input)
                num = int.Parse(input);
                //правим на нашето число(num) 
                //=> проверяваме дали num е отрицателно => не го добавяме никъде и пишем отпечатваме "Number is negative.".  и четем нов input и трябва да приключим ипълнението на това завъртане на while цикъла => continue
                if (num<0)
                {
                    Console.WriteLine("Number is negative.");
                    input = Console.ReadLine();
                    continue;

                }
                //=> проверяваме дали num е просто или непросто 
                // => ако num се раздели на някое число различно то 1 и самото num без остатък =>  то е непросто!!!!!!
                // Простото число е num > 1 и да се дели само и единствено на 1 и на себе си (num%1 == 0) && (num%num == 0) 
                bool isPrime = true; // променлива за числото дали е просто или непросто (по default му слагаме че е просто)
                // един цикъл който ще раздели num на всяко число от 2 до  num-1  // Правим го това защото реално всяко число се дели на 2 и на себе си
                for (int i = 2; i < num - 1; i++) // този цикъл е да провери дали числото е непросто или по-точно разделя нашето num с всяко всяко число освен на 1 ( затова цикъла започва от 2) и самото num се разделя на другите числа без да стига до самото num делено на num
                {
                    //ако имаме num=3  
                    if (num%i == 0) // 3%2 == 0? 
                    {
                        isPrime = false; // ако се дели на две е непросто следователно isPrime(порменливата за четно числото) става false 
                        break;
                    }
                }
                //=> ако е просто => primeSum += num    
                if (isPrime == true )
                    {
                        primeSum += num;
                    }
                    //=> ако е непросто => nonPrimeSum += num
                    else
                    {
                        nonPrimeSum += num;
                    }
                
                // в цикъла трябва всеки път да четем input 
                input = Console.ReadLine();
            }

            // когато получим input = "stop" излизаме от цикъла  
            // Отпечатваме резултат 
            // =>•	"Sum of all prime numbers is: {prime numbers sum}"	
            // =>"Sum of all non prime numbers is: {nonprime numbers sum}"

            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");



        }
    }
}