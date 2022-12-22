using System;

namespace Prime_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("The value n1: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("The value n2: ");
            int n2 = int.Parse(Console.ReadLine());

            for (int x = n1; x <= n2; x++)
            {
                int z = 0;
                for (int y = 1; y <= x; y++)
                {
                    if (x % y == 0)
                    {
                        z++;
                    }
                }
                if (z == 2)
                {
                    Console.WriteLine(x);
                }
            }

        }
    }
}
