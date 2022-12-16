using System;

class star
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {

            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            for (int k = 1; k <= (2 * n) - (2 * i); k++)
            {
                Console.Write(" ");
            }
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        //아래
        for (int i = 1; i < n; i++)
        {
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write("*");
            }
            for (int k = 1; k <= 2 * i; k++)
            {
                Console.Write(" ");
            }
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}