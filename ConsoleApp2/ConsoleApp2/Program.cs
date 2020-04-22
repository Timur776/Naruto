using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong n = ulong.Parse(Console.ReadLine());
            string S = string.Empty;
            for (ulong i=n;i>0;i/=2) 
            {
                S = (i%2) + S;
            }
            Console.WriteLine(S);
        }

    }
}
