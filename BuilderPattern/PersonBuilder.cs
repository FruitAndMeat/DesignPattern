using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    /*Builder类是为创建一个Product对象的各个部件指定的抽象接口，可以是接口形式或抽象类。*/
    /// <summary>
    /// 抽象的建造人的类。
    /// </summary>
    internal abstract  class PersonBuilder
    {
        protected Graphics g;
        protected Pen p;
        public PersonBuilder(Graphics g, Pen p) {
            this.g = g;
            this.p = p;
        }
        public abstract void BuildHead();
        public abstract void BuildBody();
        public abstract void BuildArmLeft();
        public abstract void BuildArmRight();
        public abstract void BuildLegLeft();
        public abstract void BuildLegRight();
    }
}
