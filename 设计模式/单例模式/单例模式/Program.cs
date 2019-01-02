/**
 * 单例模式
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单例模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton1 s1 = Singleton1.GetInstance();
            s1.Name = "张三";

            Singleton2 s2 = Singleton2.GetInStance();
            s2.Name = "王五";

            Console.WriteLine(s1.Name);
            Console.WriteLine(s2.Name);

            Console.ReadKey();

        }
    }
}
