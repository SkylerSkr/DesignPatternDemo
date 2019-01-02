/**
 * 访问者模式
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 访问者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建被访问的元素
            ConcreteElementA ce1 = new ConcreteElementA("元素A");
            ConCreteElementB ce2 = new ConCreteElementB("元素B");

            //创建访问者
            ConCreteVistorA c1 = new ConCreteVistorA();
            ConCreteVistorB c2 = new ConCreteVistorB();

            //访问 把访问者给元素 然后元素内部执行访问者访问自己的方法
            ce1.Accept(c1);
            ce1.Accept(c2);
            ce2.Accept(c2);

            Console.Read();
        }
    }
}
