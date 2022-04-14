using System;
using System.Threading;

namespace show_time
{
    class Program
    {
        static void Main(string[] args)

        {
            for (int i = 1; i <= 10; i++)
            {
                DateTime now = DateTime.Now;
                Console.WriteLine(now.ToString("F"));
                Thread.Sleep(1000);
                Console.Clear();

            }
        }
    }
}
