using System;

namespace namn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hur bred ska din triangel vara? ");
            int längd = int.Parse(Console.ReadLine());
            for (int x = 0; x < längd; x++)
            {
                for (int y = 0; y <= x; y++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }

        }

    }
}
