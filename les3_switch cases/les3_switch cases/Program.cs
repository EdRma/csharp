using System;
namespace Switch_Cases
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kies een getal onder de 7");
            string input = Console.ReadLine();
            int number = 0;
                number = Int32.Parse(input);
                switch (number)
                {
                    case 0:
                        Console.WriteLine("0, dit is niet een getal");
                        Console.ReadLine();
                        return;
                    case 1:
                        Console.WriteLine("1, dit is het eerste getal");
                        Console.ReadLine();
                        return;
                    case 2:
                        Console.WriteLine("2, voor de minuten dat je je tanden moet poetsen");
                        Console.ReadLine();
                        return;
                    case 3:
                        Console.WriteLine("3, het aantal primaire kleuren");
                        Console.ReadLine();
                        return;
                    case 4:
                        Console.WriteLine("4, het aantal seizoenen in een jaar");
                        Console.ReadLine();
                        return;
                    case 5:
                        Console.WriteLine("5, als je dit X 2 doet krijg je 10");
                        Console.ReadLine();
                        return;
                    case 6:
                        Console.WriteLine("6, dit is mijn favoriete getal");
                        Console.ReadLine();
                        return;
                    default:
                        Console.WriteLine("Je hebt het getal " + number + " ingevoerd, dit zit niet onder de 7");
                        Console.ReadLine();
                        return;
                }
        }
    }
}