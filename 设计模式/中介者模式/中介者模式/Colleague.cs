using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 中介者模式
{
    abstract class Colleague
    {
        protected Mediator m;

        public Colleague(Mediator m)
        {
            this.m = m;
        }

        public abstract void Send(string message);

        public abstract void Notify(string message);
    }
}
