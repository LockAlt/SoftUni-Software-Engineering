using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine()); // _ _ _ _ _ _ 
            int secondNum = int.Parse(Console.ReadLine()); // _ _ _ _ _ _ 

            int oddSum;
            int evenSum;

            for (int i = firstNum; i <= secondNum; i++)
            {
                 oddSum = 0;
                 evenSum = 0;

                string currentNum = i.ToString();//   currentNum първоначално ще е число и като дойде тук ще стане текст число

                for (int j = 0; j < currentNum.Length; j++) // Символите започват от 0 затова започваме от 0 // for (int j = 0; j <= currentNum.Length - 1; j++) - това също става защото както в миналии лекции имахме че символите в думата "око" са 2 а дължината на думата(.Length) е 3 защото символите се броят от 0 
                {
                    if (j%2==0) // Търси се дали е на четна или не четна позиция на символа
                    {
                        evenSum += currentNum[j];
                    }
                    else
                    {
                        oddSum+=currentNum[j];
                    }
                }
                if (oddSum==evenSum )
                {
                    Console.Write(currentNum + " ");
                }
            }
        }
    }
}