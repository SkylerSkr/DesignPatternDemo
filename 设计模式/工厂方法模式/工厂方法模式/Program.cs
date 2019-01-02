/**
 * 工厂方法模型
 * 简单工厂的升级版 更加贴近开放闭合原则
 * 为每一个子类写一个工厂类
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 工厂方法模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建工厂对象
            UndergraduateFactory uFactory = new UndergraduateFactory();
            VolunteerFactory vFactory = new VolunteerFactory();

            //工厂返回雷锋（父类） 实际上是子类
            LeiFeng undergraduate = uFactory.CreateLeiFeng();
            LeiFeng volunteer = vFactory.CreateLeiFeng();

            undergraduate.Sweep();
            volunteer.BuyRice();

            Console.ReadKey();
           
        }
    }
}
