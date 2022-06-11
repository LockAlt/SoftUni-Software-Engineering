using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();

            switch (country)
            {
                case "USA": // Можем така в няколко case-ове да излиза едно нещо ТАКЪВ Е СИНТАКСИСА  case " ЕДИКАКВО СИ" :( две точки) и после натам какво искаме да направи и break 
                case "England":
                    Console.WriteLine("English");
                    break;
                case "Spain":
                case "Argentina":
                case "Mexico":
                    Console.WriteLine("Spanish");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }

        }
    }
}