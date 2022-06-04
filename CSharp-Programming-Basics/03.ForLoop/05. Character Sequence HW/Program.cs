using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine(); // World
            for (int i = 0; i < message.Length; i++) // message.Lenght = 5 --> i=0 --> 0 <message.Lenght --> messege[0] nulevata poziciq bukvata ( W) i se printira posle se adva 1 i se printira 1-viqt simvol i tn.
            {
                char letter = message[i]; 
                Console.WriteLine(letter); // Vsiki bukvi gi pishe na nov red zashtoto purvata vrutka se zapazva 'W'posle pravi vtora vrutka s 'o' i tq se pishe na sledvastiq red itn.
            }

        }
    }
}