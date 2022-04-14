using System;

namespace les6_overerving
{
        internal class Program
        {
            static void Main(string[] args)
            {
                Animal whitehorse = new Horse();
                Animal blackhorse = new Horse();
                whitehorse.Feed(5);
            }
        }
        class Animal
        {
            protected int hunger
            {
                get
                {
                    return _hunger;
                }
                set
                {
                    if (value > hungermax)
                        value = hungermax;
                    _hunger = value;
                }
            }
            private int _hunger;
            protected int hungermax
            {
                get; set;
            }
            public void Feed(int v)
            {
                hunger -= 1;
            }
            public void Starve(int ammount)
            {
                hunger -= ammount;
            }
        }
        class Horse : Animal
        {
            public Horse()
            {
                hungermax = 100;
                hunger = 100;
            }
        }
    }

