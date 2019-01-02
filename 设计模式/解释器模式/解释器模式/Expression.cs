using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 解释器模式
{
    abstract class Expression
    {
        public void InterPret(PlayContext text)
        {
            if (text.Text.Length == 0) return;
            else
            {
                string key = text.Text.Substring(0,1);
                string value = text.Text.Substring(1,1);
                text.Text = text.Text.Substring(2);
                Excute(key,value);
            }
        }

        public abstract void Excute(string key,string value);
    }
}
