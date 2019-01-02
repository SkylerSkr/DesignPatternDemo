using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 适配器模式
{
    class Adapter:Target
    {
        private Adeptee adeptee = new Adeptee();
        public override void Request()
        {
            adeptee.SpecificRequest();
        }
    }
}
