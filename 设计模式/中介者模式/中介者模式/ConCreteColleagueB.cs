using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 中介者模式
{
    class ConCreteColleagueB : Colleague
    {
        public ConCreteColleagueB(Mediator m) : base(m)
        {
        }

        public override void Notify(string message)
        {
            Console.WriteLine("B收到消息"+message);
        }

        public override void Send(string message)
        {
            this.m.Send(message,this);
        }
    }
}
