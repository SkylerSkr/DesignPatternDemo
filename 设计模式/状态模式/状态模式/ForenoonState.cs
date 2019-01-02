using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 状态模式
{
    class ForenoonState : State
    {
        public override void WriteCode(Work w)
        {
            if (w.Hour < 12)
            {
                Console.WriteLine("当前时间{0}点，工作状态良好", w.Hour);
            }
            else
            {
                w.State = new NoonState();
                w.WriteCode(); 
            }
        }
    }
}
