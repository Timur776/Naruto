using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            
            {
                double res = 1;
                for (int i = K + 1; i <= N; i++)
                {
                    res *= i;
                }
                Console.WriteLine(res);
            }
            
        }
    }
}
