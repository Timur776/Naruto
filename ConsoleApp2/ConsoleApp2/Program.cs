using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = 20;
            string Celsium, Farengheit;
            for (int i = -20; i <= n; i+=2)
            {
                Console.WriteLine("Celsium "+(i)+"= Farengheit "+(i * 1.8 + 32));
            }
        }
    }
}
