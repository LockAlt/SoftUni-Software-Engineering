using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine()); // оценяващите

            for (int i = 1; i <= n; i++) // От 1 оценяващ до последния включително.
            {
                string assessorName = Console.ReadLine(); // проверяващия 
                double assessorPoints = double.Parse(Console.ReadLine());  //точките които дава

                academyPoints += assessorName.Length * assessorPoints / 2; // academyPoints =  academyPoints + assessorName.Length * assessorPoints / 2;
                
                if (academyPoints>=1250.5) // Ако акактьорът е събрал толкова точки спира ( в смисъл ако още на първото жури е субрал толкова точки няма смисъл да минава и през останалите журита)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {academyPoints:F1}!");
                    break; // for цикъла трябва да спре
                }
            }
            if (academyPoints<1250.5) // Трябва да е извън for цикъла защото ще се извежда всеки път когато минава врътката ако не премине още на първото жури
            {
                Console.WriteLine($"Sorry, {actorName} you need {1250.5 - academyPoints :F1} more!");
            }
        }
    }
}