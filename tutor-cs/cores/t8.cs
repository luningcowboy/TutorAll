using System;

class Program
{
    static void Main(string[] args)
    {
        int points = 100;
        string msg = "";
        switch(points / 10)
        {
            case 10:
                msg = "优秀";
                break;
            case 9:
                msg = "优秀";
                break;
            case 8:
                msg = "优秀";
                break;
            case 7:
                msg = "优秀";
                break;
            case 6:
                msg = "优秀";
                break;
            default:
                msg = "不及格";
                break;
        }
        Console.WriteLine(msg);
    }
}
