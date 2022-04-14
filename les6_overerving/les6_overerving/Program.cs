using System;

namespace les6_overerving
{
    class Animal
    {
        public void feed()
        {
            Console.WriteLine("feed :)");
        }
    }
    class horse : Animal
    {
        public string ras = "pony";
    }
    class horsenom
    {
        static void Main(string[] args)
        {
            horse myanimal = new horse();
            myanimal.feed();
        }

    }
}