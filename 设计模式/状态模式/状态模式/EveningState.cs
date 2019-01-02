using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 状态模式
{
    class EveningState : State
    {
        public override void WriteCode(Work w)
        {
            if (w.TaskFinished)
            {
                w.State = new RestState();
                w.WriteCode();
            }
            else
            {
                Console.WriteLine("当前时间{0}点，加班了,好累啊", w.Hour);
            }
        }
    }
}
