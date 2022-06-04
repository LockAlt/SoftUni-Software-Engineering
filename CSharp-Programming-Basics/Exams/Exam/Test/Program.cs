using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleInGroup = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double transportCards = int.Parse(Console.ReadLine());
            int tickets = int.Parse(Console.ReadLine());

            int onePerson = 0;
            double onePersonFull = 0;
            double Group = 0;

            onePerson = nights * 20;
            transportCards = transportCards * 1.60;
            tickets = tickets * 6;
            onePersonFull = onePerson + transportCards + tickets;
            Group = onePersonFull * peopleInGroup;

            Group = Group + (Group * 25 / 100);

            Console.WriteLine($"{Group:F2}");

        }
    }
}