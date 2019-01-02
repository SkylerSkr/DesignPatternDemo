/**
 * 桥接模式
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 桥接模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //组合聚合 让RefindedAbstion具有ConcreteImplementorA的功能
            RefinedAbstaction r1 = new RefinedAbstaction(new ConcreteImplementorA());
            r1.Operation();

            //组合聚合 让RefindedAbstion具有ConcreteImplementorB的功能
            RefinedAbstaction r2 = new RefinedAbstaction(new ConcreateImplementorB());
            r2.Operation();

            Console.ReadKey();

        }
    }
}
