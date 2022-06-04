using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string text = Console.ReadLine(); // Hello

            int sum = 0;
            
            for (int i = 0; i < text.Length; i++)
            {
               //int sum = 0;  TOVA E GRESHKA ZAHSTOTO AKO Q BQHME SAZDALI TUK POSLE NQMASHE DA MOJEM DA Q PRINTIRAME I KATO SE NAPRAVI SLEDVASHATA OBIKOLKA SHTE SE REFRESHNE STOINOSTA PAK NA 0 
                
                char currentSymbol = text[i]; //'h' purvo shte izleze 'h' zashtoto i =0 v purvata obikolka a simvola e h = 0, posle sta i=1 koeto e 'e' i vliza v swith i sumata stava 2 i tn.
                switch (currentSymbol)
                {
                    case 'a':
                        sum++; // sum+=1
                        break;
                    case 'e':
                        sum += 2;
                        break;
                    case 'i':
                        sum += 3;
                        break;
                    case 'o':
                        sum += 4;
                        break;
                    case 'u':
                        sum += 5;
                        break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}