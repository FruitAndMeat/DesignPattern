using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    /// <summary>
    /// 这里是Decorator类
    /// </summary>
    internal class Finery:Person
    {
        protected Person component;
        //打扮
        public void Decorate(Person component) {
            this.component = component;
        }

        public override void Show() {
            if (component!=null) {
                component.Show();
            }
        }
    }
}
