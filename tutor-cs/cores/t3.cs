using System;
class Program{
    static void Main(string[] args)
    {
        int a = 100;
        int b = 200;
        Console.WriteLine("交换前:");
        Console.WriteLine("a = "+ a+ ";b = "+ b);
        int temp;
        temp = a;
        a = b;
        b = temp;
        Console.WriteLine("交换后:");
        Console.WriteLine("a = "+ a+ ";b = "+ b);
    }
}
