using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    class CashReturn:CashSuper
    {
        private double _moneyCondition;
        private double _moneyReturn;

        public CashReturn(double condition,double moneyReturn)
        {
            this.MoneyCondition = condition;
            this.MoneyReturn = moneyReturn;
        }

        public override double acceptCash(double money)
        {
            if (money > MoneyCondition) return money - MoneyReturn;
            return money;
        }

        public double MoneyCondition { get => _moneyCondition; set => _moneyCondition = value; }
        public double MoneyReturn { get => _moneyReturn; set => _moneyReturn = value; }
    }
}
