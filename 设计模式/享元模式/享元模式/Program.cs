/**
 * 享元模式
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 享元模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建工厂类
            FlyweightFactory factory = new FlyweightFactory();
            factory.GetFlyweight("woc");
            factory.GetFlyweight("尼玛");
            factory.GetFlyweight("woc");
            Console.WriteLine(factory.Count());

            factory.Play();

            Console.ReadKey();
        }
    }
}
