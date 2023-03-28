using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    /// <summary>
    /// 追求者类
    /// </summary>
    internal class Prusuit : GiveGift
    {
        SchoolGirl mm;
        public Prusuit(SchoolGirl mm) {
            this.mm = mm;
        }

        public void GiveCholoclate() {
            Console.WriteLine(mm.Name+" 送你巧克力");
        }

        public void GiveDolls() {
            Console.WriteLine(mm.Name + " 送你洋娃娃");
        }

        public void GiveFlowers() {
            Console.WriteLine(mm.Name + " 送你鲜花");
        }
    }
}
