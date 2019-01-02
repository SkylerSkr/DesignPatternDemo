using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 代理模式
{
    class Pursuit:IGiveGift
    {
        SchoolGirl _girl;

        public Pursuit(SchoolGirl girl)
        {
            this._girl = girl;
        }

        public void GiveChocolate()
        {
            Console.WriteLine(_girl.Name+"送你巧克力");
        }

        public void GiveDolls()
        {
            Console.WriteLine(_girl.Name + "送你布娃娃");
        }

        public void GiveFlowers()
        {
            Console.WriteLine(_girl.Name + "送你花");
        }
    }
}
