using System;

class Program
{
    static void Main(string[] args)
    {
        for(int i = 0; i < 10; i++)
        {
            if (i == 4)
            {
                break;
            }
            Console.WriteLine(i);
        }
    }
}
