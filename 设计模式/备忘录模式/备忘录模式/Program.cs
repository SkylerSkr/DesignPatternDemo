/**
 * 备忘录模式
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 备忘录模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建角色
            Originator o = new Originator("史柯",19,183);
            //创建备忘录管理者
            CareTaker c = new CareTaker();
            c.Memento = o.CreateMemento();
            Console.WriteLine(o);

            //更改状态
            o.Name = "徐佳丽";
            o.Age = 20;
            o.Heigth = 160;
            Console.WriteLine(o);

            //还原状态
            o.SetMemento(c.Memento);
            Console.WriteLine(o);

            Console.ReadKey();
        }
    }
}
