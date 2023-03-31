using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    //ThinBuilder和FatBuilder这两个类实际是ConcreteBuilder类，它是具体建造者，实
    //现Builder接口，构造和装配各个部件。
    //Product当然就是这里具体的小人了、产品角色了。
    internal class PersonThinBuilder : PersonBuilder
    {
        public PersonThinBuilder(Graphics g,Pen p):base(g,p) {

        }
        public override void BuildArmLeft() {
            g.DrawLine(p, 60, 50, 40, 100);
        }

        public override void BuildArmRight() {
            g.DrawLine(p, 70, 50, 90, 100);
        }

        public override void BuildBody() {
            g.DrawRectangle(p, 60, 50, 10, 50);
        }

        public override void BuildHead() {
            g.DrawEllipse(p, 50, 20, 30, 30);
        }

        public override void BuildLegLeft() {
            g.DrawLine(p, 60, 100, 45, 150);
        }

        public override void BuildLegRight() {
            g.DrawLine(p, 70, 100, 85, 150);
        }
    }
}
