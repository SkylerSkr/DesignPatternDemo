
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    class CashContext
    {
        private CashSuper cs=null;

        public CashContext(string operate)
        {
            switch (operate)
            {
                case "无优惠":
                    cs = new CashNormal();
                    break;
                case "满500减100":
                    cs = new CashReturn(500,100);
                    break;
                case "全场8折":
                    cs = new CashRebate(0.8d);
                    break;
            }
        }

        public double GetResult(double money)
        {
            return cs.acceptCash(money);
        }
    }
}
