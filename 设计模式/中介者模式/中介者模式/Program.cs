/**
 * 中介者模式
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 中介者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建中介者
            ConcretaMediator cm = new ConcretaMediator();
            //创建需要协调的对象 并让它们认识中介者
            ConcreteColleagueA c1 = new ConcreteColleagueA(cm);
            ConCreteColleagueB c2 = new ConCreteColleagueB(cm);

            //让中介者认识需要协调的对象
            cm.C1 = c1;
            cm.C2 = c2;

            //发送消息
            c1.Send("你吃了嘛");
            c2.Send("还没呐 要不要一起");

            Console.ReadKey();
        }
    }
}
