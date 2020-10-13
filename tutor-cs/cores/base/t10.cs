using System;

class Program
{
    static void Main(string[] args)
    {
        for(int i = 1; i <= 3; i++)
        {
            for(int j = 1; j < 3 - i; j++)
            {
                Console.Write(" ");
            }
            for(int k = 1; k < 2 * i; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        for(int i = 2; i >= 1; i--)
        {
            for(int j = 1; j < 3 - i; j++)
            {
                Console.Write(" ");
            }
            for(int k = 1; k < 2 * i - 1; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

    }
}
