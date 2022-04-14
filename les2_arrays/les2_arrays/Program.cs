using System;

namespace les2_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 10, 20, 30, 40, 50, 60};
            int tel = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                tel += arr[i];
            }
            Console.WriteLine(tel);
        }
    }
}
