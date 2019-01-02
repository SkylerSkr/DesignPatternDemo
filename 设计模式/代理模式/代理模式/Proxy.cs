using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 代理模式
{
    class Proxy : IGiveGift
    {
        Pursuit _pursuit;

        public Proxy(SchoolGirl girl)
        {
            _pursuit = new Pursuit(girl);
        }

        public void GiveChocolate()
        {
            _pursuit.GiveChocolate();
        }

        public void GiveDolls()
        {
            _pursuit.GiveDolls();
        }

        public void GiveFlowers()
        {
            _pursuit.GiveFlowers();
        }
    }
}
