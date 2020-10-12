using System;

/// 类定义
/// 类访问修饰符 修饰符 类名
/// 类访问修饰符 public internal
/// public: 其他程序也能访问
/// internal: 只有当前程序能够访问
/// 修饰符 static abstract sealed
/// static: 不能被实例化
/// abstract: 不能被实例化
/// sealed: 不能被继承

/// TestStatic
internal static class TestStatic
{
    public static int ATTR_0 = 0;
    public static int ATTR_1 = 1;
}

/// 抽象类
public abstract class Base{
    //public virtual void Display();
    public abstract void Display();
}

/// 从抽象类继承
class B1 : Base{
    public B1(){}
    public override void Display(){
        Console.WriteLine("B1:Display");
    }
}

/// 测试TestSealed
sealed class TestSealed
{
    public TestSealed()
    {
    }

    public void Display()
    {
        Console.WriteLine("TestSealed:Display");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("HelloWorld");
        Console.WriteLine($"TestStatic:ATTR_0 = {TestStatic.ATTR_0}");
        var b1 = new B1();
        b1.Display();
        var testSealed = new TestSealed();
        testSealed.Display();
    }
}
