/**
 * 建造者模式
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 建造者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //指挥者
            Director d = new Director();

            //建造者 没个建造者都知道自己建造的是什么 所以不需要指定
            ConcreteBuilderA builder1 = new ConcreteBuilderA();
            ConcreteBuilderB builder2 = new ConcreteBuilderB();

            //指挥者指挥建造者
            Product p1= d.Construct(builder1);
            Product p2 = d.Construct(builder2);

            p1.Show();
            p2.Show();

            Console.ReadKey();

            
        }
    }
}
