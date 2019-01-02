using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    class CashRebate:CashSuper
    {
        private double _rebate;

        public CashRebate(double rebate)
        {
            this.Rebate = rebate;
        }

        public override double acceptCash(double money)
        {
            return money * _rebate; ;
        }

        public double Rebate { get => _rebate; set => _rebate = value; }
    }
}
