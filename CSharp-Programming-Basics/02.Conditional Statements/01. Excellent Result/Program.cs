using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            if (grade >= 5.50) // Tova e uslovieto i pri tova uslovie vlizame v bloka ot dolu i ako e izpulneno izliza Excellent!
            {
                Console.WriteLine("Excellent!"); // Ako napishem 5.09 nqma da se otpechata nishto zashtoto ocenkata e po-malka ot 5.50 //Ako napishem 5.60 shte se napishe Excellent zashtoto uslovieto ( grade <= 5.50 e True)
            }
        }
    }
}