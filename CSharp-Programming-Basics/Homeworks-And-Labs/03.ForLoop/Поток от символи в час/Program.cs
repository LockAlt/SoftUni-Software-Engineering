using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "SoftUni";
            //Console.WriteLine(text[0]);
            //Console.WriteLine(text[1]);
            //Console.WriteLine(text[2]);
            //Console.WriteLine(text[3]);
            //Console.WriteLine(text[4]);
            //Console.WriteLine(text[5]);
            //Console.WriteLine(text[6]);  // Tova cqloto e za vsqka bukva na otdolen red  tova moje da stane no s for cikal e po-lesno

            //for (int i = 0; i < 7; i++) 
            //{
            //    Console.WriteLine(text[i]);
            //}

            for (int i = 0; i < text.Length; i++) // Tuk e text.Lenght zashtoto ako imame duma primerno s 2 simvola a nie sme zadali i<7 programata sled vtorata obikolka shte ni dade error zashtoto ne znae ot kude da vzeme ostanalite 5 simvola
            {
                Console.WriteLine(text[i]);
            }

        }
    }
}