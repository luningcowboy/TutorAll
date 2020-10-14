using System;
public class Panda
{
    public string name;
    public static int population;

    public Panda(string _name)
    {
        name = _name;
        population = population + 1;
    }
}

public class Program
{
    static void Main(string[] args)
    {
        var p1 = new Panda("p1");
        var p2 = new Panda("p2");
        Console.WriteLine(p1.name);
        Console.WriteLine(p2.name);
        Console.WriteLine(Panda.population);
    }
}
