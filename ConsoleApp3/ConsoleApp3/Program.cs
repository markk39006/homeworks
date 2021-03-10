using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input Mode: ");
            string mode = Console.ReadLine();
            Console.Write("input X: ");
            float x = float.Parse(Console.ReadLine());
            Console.Write("input Y: ");
            float y = float.Parse(Console.ReadLine());
            if (mode == "time")
            {
                if (x < 0)
                {
                    Console.WriteLine("Invalid mouse position");
                }
                else
                {
                    double p1 = Math.Pow(x - 1, 2);
                    double t1 = Math.Abs(Math.Sqrt(p1) + 1);
                    Console.WriteLine("{0:f},{1:f}", t1, p1);
                }
            }
            else if (mode == "price")
            {
                if (x < 0)
                {
                    Console.WriteLine("Invalid mouse position");
                }
                else
                {
                    double t2 = Math.Abs(Math.Sqrt(y) + 1);
                    double p2 = Math.Pow(t2 - 1, 2);
                    Console.WriteLine("{0:f},{1:f}", t2, p2);
                }
            }
            else
            {
                Console.WriteLine("Invalid mode");
            }
            Console.ReadLine();

        }
    }
}
