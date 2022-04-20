using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace les5_namespaces
{
    class Class1
    {
        private int peop;

        public void Feed(int amount)
        {
            peop -= amount;
            Console.WriteLine(peop);
        }
    }
}
