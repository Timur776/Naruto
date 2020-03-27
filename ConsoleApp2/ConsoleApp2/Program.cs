using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = 300;
            string Celsium, Farengheit;
            for (int i = 300; i >= 0; i-=5)
            {
                Console.WriteLine("Celsium "+(i)+"= Farengheit "+(i * 1.8 + 32));
            }
        }
    }
}
