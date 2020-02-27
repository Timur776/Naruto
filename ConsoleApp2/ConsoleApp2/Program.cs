using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            
                if (a <= b && b <= c) 
                {
                Console.WriteLine(c);
                Console.WriteLine(b);
                Console.WriteLine(a);
                }
                if (a <= c && c <= b)
                {
                Console.WriteLine(b);
                Console.WriteLine(c);
                Console.WriteLine(a);
                }
                if (b <= a && a <= c)
                {
                Console.WriteLine(c);
                Console.WriteLine(a);
                Console.WriteLine(b);
                }
                if (b <= c && c <= a)
                { 
                Console.WriteLine(c);
                Console.WriteLine(c);
                Console.WriteLine(b);
                }
                if (c <= a && a <= b)
                {
                Console.WriteLine(b);
                Console.WriteLine(a);
                Console.WriteLine(c);
                }
                if (c <= b && b <= a)
                {
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);
                }
        }
    }
}
