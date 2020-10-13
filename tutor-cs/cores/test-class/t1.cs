/// 方法的定义
/// 访问修饰符 修饰符 返回值类型 方法名(参数表)
/// 访问修饰符:默认是private
/// 修饰符:
/// virtual 虚拟的
/// abstract 抽象的
/// override 重写的 类继承的时候使用
/// static 静态的
/// sealed 密封的 不能被继承
/// 


using System;
namespace Code
{
    class Test
    {
        private int id;
        public readonly string name;
        internal static int age;
        private const string major = "计算机";

        private void PrintMSG()
        {
            Console.WriteLine("编号:" + id);
            Console.WriteLine("姓名:" + name);
            Console.WriteLine("年龄:" + age);
            Console.WriteLine("专业:" + major);
        }
    }
}
