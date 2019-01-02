using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 组合模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Composite c = new Composite("老大");
            Composite c1 = new Composite("老二");
            Composite c2 = new Composite("老三");

            Leaf l1 = new Leaf("小弟1");
            Leaf l2 = new Leaf("小弟2");
            Leaf l3 = new Leaf("小弟3");
            Leaf l4 = new Leaf("小弟4");
            Leaf l5 = new Leaf("小弟5");
            Leaf l6 = new Leaf("小弟6");
            Leaf l7 = new Leaf("小弟7");

            c.Add(l1);
            c.Add(l2);
            c1.Add(l3);
            c1.Add(l4);
            c1.Add(l5);
            c1.Add(l6);
            c2.Add(l7);
            c.Add(c1);
            c.Add(c2);

            c.DisPlay(1);

            Console.ReadKey();
        }
    }
}
