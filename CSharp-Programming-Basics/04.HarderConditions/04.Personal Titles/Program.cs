using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());

            switch (gender)
            {
                case 'f': // Tova ti e kato if 'f' i nadolu sa ti vlojeni proverki v samiq case 'f'
                    if (age < 16)
                    {
                        Console.WriteLine("Miss");
                    }
                    else // Tuk e ako age >= 16
                    {
                        Console.WriteLine("Ms.");
                    }
                    break;
                case 'm':
                    if (age < 16)
                    {
                        Console.WriteLine("Master");
                    }
                    else
                    {
                        Console.WriteLine("Mr.");
                    }
                    break;
            }
        }
    }
}