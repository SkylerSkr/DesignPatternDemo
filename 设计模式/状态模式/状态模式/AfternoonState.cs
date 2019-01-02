using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 状态模式
{
    class AfternoonState : State
    {
        public override void WriteCode(Work w)
        {
            if (w.Hour < 17)
            {
                Console.WriteLine("当前时间{0}点，下午状态还不错,继续努力", w.Hour);
            }
            else
            {
                w.State = new EveningState();
                w.WriteCode();
            }
        }
    }
}
