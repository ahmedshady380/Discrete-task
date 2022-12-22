using System;

class Program
{
    public static void Main(string[] args)
    {

        Console.Write(" Enter The Value n1 : ");
        int n1 = int.Parse(Console.ReadLine());

        Console.Write(" Enter The Value n2 : ");
        int n2 = int.Parse(Console.ReadLine());

        for (int x = n1; x <= n2; x++)
        {
            int z = 1;
            for (int y = 2; y < x; y++)
            {
                if (x % y == 0)
                {
                    z += y;
                }
            }
            if ((z == x) && (z != 1))
            {
                Console.WriteLine(x);
            }
        }




    }
}