using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int K = int.Parse(Console.ReadLine());
            int L = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());

            int changes = 0;
            

            for (int i = K; i <= 8; i++)  
            {
                if (i % 2 != 0)
                {
                    continue;
                }
                if (changes == 6)
                {
                    break;
                }
                for (int j = 9; j >= L; j--)
                {
                    if (j % 2 == 0)
                    {
                        continue;
                    }
                    if (changes == 6)
                    {
                        break;
                    }
                    for (int g = M; g <= 8; g++)
                    {
                        if (g % 2 != 0)
                        {
                            continue;
                        }
                        if (changes == 6)
                        {
                            break;
                        }
                        for (int x = 9; x >= N; x--)
                        {
                            if (x % 2 == 0)
                            {
                                continue;
                            }
                            if (i==g && j==x)
                            {
                                Console.WriteLine("Cannot change the same player.");
                            }
                            else
                            {
                                Console.WriteLine($"{i}{j} - {g}{x}");
                                changes++;
                            }
                            if (changes == 6)
                            {
                                break;
                            }

                        }                      
                    }                   
                }                
            }           
        }
    }
}