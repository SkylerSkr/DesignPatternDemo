using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 中介者模式
{
    class ConcretaMediator : Mediator
    {
        private ConcreteColleagueA _c1;

        internal ConcreteColleagueA C1 { set => _c1 = value; }
        internal ConCreteColleagueB C2 {set => _c2 = value; }

        private ConCreteColleagueB _c2;

        public override void Send(string message, Colleague colleague)
        {
            if (_c1==colleague)
            {
                _c2.Notify(message);
            }
            else
            {
                _c1.Notify(message);
            }
        }
    }
}
