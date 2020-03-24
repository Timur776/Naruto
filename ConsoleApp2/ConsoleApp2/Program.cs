using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
                   for (int i = 0; i <= n; i++)
            if (i % (3 * 7) != 0)
                {
                    Console.WriteLine(i);
                }
            
        }
    }
}