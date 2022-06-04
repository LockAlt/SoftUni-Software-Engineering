using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfTournaments = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());

            double winner = 0;
            double finalist = 0;
            double semifinalist = 0;

            double totalPoints = 0;
            double avaragePoits = 0;

            double timesWinner = 0;

            for (int i = 1; i <= numberOfTournaments; i++)
            {
                string typeOFTournament = Console.ReadLine();
                if (typeOFTournament == "W")
                {
                    winner += 2000;
                    timesWinner++;
                }
                else if (typeOFTournament == "F")
                {
                    finalist += 1200;
                }
                else
                {
                    semifinalist += 720;
                }

            }
            totalPoints = winner + finalist + semifinalist;
            Console.WriteLine($"Final points: {totalPoints+startingPoints}");

            avaragePoits = totalPoints / numberOfTournaments;
            Console.WriteLine($"Average points: {Math.Floor(avaragePoits)}");

            double percenWinTournaments = 0;
            percenWinTournaments = timesWinner / numberOfTournaments * 100;

            Console.WriteLine($"{percenWinTournaments:f2}%");
            
        }
    }
}