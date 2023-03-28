using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    /// <summary>
    /// 代理者类
    /// </summary>
    internal class Proxy : GiveGift
    {
        Prusuit gg;
        public Proxy(SchoolGirl mm) {
            this.gg = new Prusuit(mm);
        }

        public void GiveCholoclate() {
            gg.GiveCholoclate();
        }

        public void GiveDolls() {
            gg.GiveDolls();
        }

        public void GiveFlowers() {
            gg.GiveFlowers();
        }
    }
}
