using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("HelloWorld");
        string username = "aab";
        string pass = "123";
        if (username != "aaa" || pass != "123")
        {
            goto tag_end;
        }
        else{
            Console.WriteLine("Login Success");
            return;
        }

tag_end:
        Console.WriteLine("end");

    }
}
