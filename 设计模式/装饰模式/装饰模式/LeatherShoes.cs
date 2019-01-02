using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰模式
{
    class LeatherShoes:Finery
    {
        public override void Show()
        {
            Console.Write("破球鞋");
            base.Show();
        }
    }
}
