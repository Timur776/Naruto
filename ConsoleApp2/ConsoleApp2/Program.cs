using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 15;
            int m = 5;

            for (int i = 2; i < n; i++)
            {
                for (int j = 1; j < m; j++)
                {
                    switch (i)
                    {
                        case 2:
                            Console.Write("два ");
                            break;
                        case 3:
                            Console.Write("три ");
                            break;
                        case 4:
                            Console.Write("четыре ");
                            break;
                        case 5:
                            Console.Write("пять ");
                            break;
                        case 6:
                            Console.Write("шесть ");
                            break;
                        case 7:
                            Console.Write("семь ");
                            break;
                        case 8:
                            Console.Write("восемь ");
                            break;
                        case 9:
                            Console.Write("девять ");
                            break;
                        case 10:
                            Console.Write("десять ");
                            break;
                        case 11:
                            Console.Write("волет ");
                            break;
                        case 12:
                            Console.Write("дама ");
                            break;
                        case 13:
                            Console.Write("колроь ");
                            break;
                        case 14:
                            Console.Write("туз ");
                            break;
                    }
                    switch (j)
                    {
                        case 1:
                            Console.WriteLine("пика");
                            break;
                        case 2:
                            Console.WriteLine("трефа");
                            break;
                        case 3:
                            Console.WriteLine("бубна");
                            break;
                        case 4:
                            Console.WriteLine("черва");
                            break;
                    }
                }
            }
        }
    }
}
