using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 解释器模式
{
    class PlayContext
    {
        private string _text;

        public PlayContext(string text)
        {
            this.Text = text;
        }

        public string Text { get => _text; set => _text = value; }
    }
}
