using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 100;
        int b = 200;
        Console.WriteLine("交换前:");
        Console.WriteLine($"a = {a}, b = {b}");
        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine("交换后:");
        Console.WriteLine($"a = {a}, b = {b}");
    }
}
