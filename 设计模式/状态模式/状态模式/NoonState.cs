using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 状态模式
{
    class NoonState : State
    {
        public override void WriteCode(Work w)
        {
            if (w.Hour < 13)
            {
                Console.WriteLine("当前时间{0}点，饿了，吃饭午睡", w.Hour);
            }
            else
            {
                w.State = new AfternoonState();
                w.WriteCode();
            }
        }
    }
}
