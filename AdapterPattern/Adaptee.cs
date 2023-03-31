using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    /// <summary>
    /// 需要适配的类Adaptee，也就是本例中的外籍中锋即姚明。
    /// </summary>
    internal class ForeignCenter
    {
        private string name;

        public string Name { get => name; set => name = value; }

        public void 进攻() {
            Console.WriteLine($"外籍中锋{name}进攻");
        }

        public void 防守() {
            Console.WriteLine($"外籍中锋{name}防守");
        }
    }

    
}
