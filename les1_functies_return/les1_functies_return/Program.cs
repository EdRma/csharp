using System;

namespace les1_functies_return
{
    class Program
    {
        static void Main(string[] args)
        {
            Program programInstance = new Program();
            int result = programInstance.Add(17, 39);
            Console.WriteLine(result);
        }
        
        private int Add(int num1, int num2)
        {
            int total;
            total = num1 + num2;
            return total;
        }
    }
}
