using System;

namespace les3_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            int Nummer1 = 13;
            int Nummer2 = 6;

            Rekenmachine rekenmachine = new Rekenmachine();
            rekenmachine.Keer(Nummer1, Nummer2);
            rekenmachine.Delen(Nummer1, Nummer2);
            rekenmachine.Plus(Nummer1, Nummer2);
            rekenmachine.Min(Nummer1, Nummer2);

            Console.WriteLine(Nummer1 + " x " + Nummer2 + " = " + rekenmachine.Keer(Nummer1, Nummer2));
            Console.WriteLine(Nummer1 + " / " + Nummer2 + " = " + rekenmachine.Delen(Nummer1, Nummer2));
            Console.WriteLine(Nummer1 + " + " + Nummer2 + " = " + rekenmachine.Plus(Nummer1, Nummer2));
            Console.WriteLine(Nummer1 + " - " + Nummer2 + " = " + rekenmachine.Min(Nummer1, Nummer2));
        }
        class Rekenmachine
        {
            public int Keer(int Nummer1, int Nummer2)
            {
                int Antwoord;
                Antwoord = Nummer1 * Nummer2;
                return Antwoord;
            }
            public int Delen(int Nummer1, int Nummer2)
            {
                int Antwoord;
                Antwoord = Nummer1 / Nummer2;
                return Antwoord;
            }
            public int Plus(int Nummer1, int Nummer2)
            {
                int Antwoord;
                Antwoord = Nummer1 + Nummer2;
                return Antwoord;
            }
            public int Min(int Nummer1, int Nummer2)
            {
                int Antwoord;
                Antwoord = Nummer1 - Nummer2;
                return Antwoord;
            }
        }
    }
}
