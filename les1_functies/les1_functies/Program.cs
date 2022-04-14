using System;

namespace les1_functies
{
    class Program
    {
        public void Show(string value)
        {
            Console.WriteLine(value);
        }
        static void Main(string[] args)
        {
            Program programInstance = new Program();
            programInstance.Show("goedemorgen");
        }
    }
}