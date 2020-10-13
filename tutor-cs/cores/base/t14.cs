using System;

class Program
{
    static void Main(string[] args)
    {
        for(int i = 0; i <= 5; i++)
        {
            if(i == 4)
            {
                continue;
            }
            Console.WriteLine(i);
        }
    }
}
