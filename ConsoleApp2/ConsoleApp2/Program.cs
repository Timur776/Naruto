using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string S =Console.ReadLine();
            int n = 0;
            for(int i = 0; i < S.Length; i++)
            { 
             n+= ((int)  Math.Pow(2, i))*(S[S.Length - 1-i]-'0');
            }
            Console.WriteLine(n);
        }

    }
}
