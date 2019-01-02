using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 模板方法模式
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass a;

            a = new ConCreteClassA();
            a.TemplateMethod();

            a = new ConCreateClassB();
            a.TemplateMethod();

            Console.ReadKey();
        }
    }
}
