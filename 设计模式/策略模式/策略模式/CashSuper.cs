using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    class CashSuper
    {
        public virtual double acceptCash( double money)
        {
            return money;
        }
    }
}
