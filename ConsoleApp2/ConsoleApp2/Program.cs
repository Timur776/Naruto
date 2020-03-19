using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            char n =char.Parse(Console.ReadLine());
            switch (n)
            {
                case 'i':
                    int i = int.Parse(Console.ReadLine());
                    Console.WriteLine(i + 1);
                    break;

                case 'd':
                    double d = double.Parse(Console.ReadLine());
                    Console.WriteLine(d + 1);
                    break;

                case 's':
                    string s = Console.ReadLine();
                    Console.WriteLine(s + '*');
                    break;

            }

        }
    }
}
