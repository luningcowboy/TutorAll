using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input:");
        int num = int.Parse(Console.ReadLine());
        if (num % 2 == 0)
        {
            Console.WriteLine("偶数");
        }
        else
        {
            Console.WriteLine("奇数");
        }
    }
}
