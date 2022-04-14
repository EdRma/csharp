using System;

namespace les5_getters_en_setters
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog hond = new Dog();
            hond.pootgeven();
        }
        public class Dog
        {
            internal paw pootgeven()
            {
                return hondenpoot;
            }
            private paw hondenpoot = new paw();
        }
        public class paw
        {

        }
    }
}