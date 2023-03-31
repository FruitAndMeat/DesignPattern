using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    /// <summary>
    /// 适配器类Adapter，也就是本例中的翻译类
    /// </summary>
    internal class Translator : Player
    {
        //声明并实例化一个内部“外籍中锋”对象，表明翻译者与外籍球员有关联
        private  ForeignCenter wjzf=new ForeignCenter();
        public Translator(string name):base(name) {
            wjzf.Name = name;
        }


        public override void Attack() {
            wjzf.进攻();
        }

        public override void Defense() {
            wjzf.防守();
        }
    }
}
