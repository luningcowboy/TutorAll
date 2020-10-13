using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World");
        int i = 0;
        int sum = 0;
        while(i < 10)
        {
            sum += i;
            i++;
        }
        Console.WriteLine($"sum = {sum}");
    }
}
