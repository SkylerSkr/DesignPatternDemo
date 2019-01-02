/**
 * 代理模式
 * 1。远程代理 为一个对象在不同的地址空间提供局部地址 隐藏一个对象存在不同地址空间的事实
 * 2。虚拟代理 存放实例化开销很大的真是对象
 * 3。安全代理 控制真实对象的访问权限
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 代理模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建被追求者
            SchoolGirl girl = new SchoolGirl("芳芳");

            //创建追求者
            Pursuit pursuit = new Pursuit(girl);

            //创建代理追求者
            Proxy proxy = new Proxy(girl);

            //代理者执行的是追求者里的方法
            proxy.GiveChocolate();
            proxy.GiveDolls();
            proxy.GiveFlowers();

            Console.ReadKey();
        }
    }
}
