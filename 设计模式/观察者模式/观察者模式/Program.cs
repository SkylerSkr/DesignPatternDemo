using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 观察者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Boss boss = new Boss("胡汉三");
            StockObserver so1 = new StockObserver("阿三",boss);
            StockObserver so2 = new StockObserver("阿四",boss);
            boss.Update += so1.Updata;
            boss.Update += so2.Updata;
            boss.Notify();
            Console.ReadKey();
        }
    }
}
