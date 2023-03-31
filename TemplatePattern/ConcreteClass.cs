using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    internal class ConcreteClassA : AbstractClass
    {
        public override void PrimitiveOperation1() {
            Console.WriteLine("具体类A方法1实现");
        }

        public override void PrimitiveOperation2() {
            Console.WriteLine("具体类A方法2实现");
        }
    }
    internal class ConcreteClassB : AbstractClass
    {
        public override void PrimitiveOperation1() {
            Console.WriteLine("具体类B方法1实现");
        }

        public override void PrimitiveOperation2() {
            Console.WriteLine("具体类B方法2实现");
        }
    }
}
