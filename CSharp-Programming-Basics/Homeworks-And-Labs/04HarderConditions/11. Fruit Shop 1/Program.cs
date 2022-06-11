using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double price = 0;



            switch (dayOfTheWeek)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    switch (fruit)
                    {
                        case "banana":
                            price = 2.50;
                            break;
                        case "apple":
                            price = 1.20;
                            break;
                        case "orange":
                            price = 0.85;
                            break;
                        case "grapefruit":
                            price = 1.45;
                            break;
                        case "kiwi":
                            price = 2.70;
                            break;
                        case "pineapple":
                            price = 5.50;
                            break;
                        case "grapes":
                            price = 3.85;
                            break;
                        default:
                                Console.WriteLine("error"); // Taka se pravi za plodovete error
                            break;
                    }
                    break;// Mnogo e vajno da go ima tuk tozi break ako ti e s takiva vlojeni proverki s switch
                case "Saturday":
                case "Sunday":
                    switch (fruit)
                    {
                        case "banana":
                            price = 2.70;
                            break;
                        case "apple":
                            price = 1.25;
                            break;
                        case "orange":
                            price = 0.90;
                            break;
                        case "grapefruit":
                            price = 1.60;
                            break;
                        case "kiwi":
                            price = 3;
                            break;
                        case "pineapple":
                            price = 5.60;
                            break;
                        case "grapes":
                            price = 4.20;
                            break;
                        default:
                                Console.WriteLine("error"); // Taka se pravi za plodovete error
                                break;
                    }
                    break; // Mnogo e vajno da go ima tuk tozi break ako ti e s takiva vlojeni proverki s switch
                default:
                        Console.WriteLine("error"); // TUK OTPECHATVAME ERROR V SWITCH ZA DNITE( Demek sled kato sme svurshili vsicki casove nie go slagame za vs vse edno) TAKA CHE AKO VUVEDEM GRESHEN PLOD NQMA DA NI IZLEZE ERROR ZATOVA TRQBVA DA SLOJIM I TOVA SUSHTOTO V FRUIT SWITCHA
                        break;
                    
            }
            
            double totalPrice = price * quantity;
            if (totalPrice != 0)
            {
                Console.WriteLine($"{totalPrice:F2}");
            }
            
        }
    }
}