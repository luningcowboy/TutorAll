using System;

class Program
{
    static void Main(string[] args)
    {
        int i = 1;
        int sum = 0;
        do
        {
            sum += i;
            i++;
        }while(i < 10);
        Console.WriteLine($"sum = {sum}");
    }
}
