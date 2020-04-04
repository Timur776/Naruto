using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            double Y = 1;
            double S = 1;
            for (int i = 1; i <= n; i++)
            {
                Y *= ((double)i)/x;
                S += Y;
            }
            Console.WriteLine(S);
        }

    }
}
