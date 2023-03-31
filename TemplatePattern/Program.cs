using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 模板方法模式：当我们要完成在某一细节层次一致的一个过程或一系列步骤，
 * 但其个别步骤在更详细的层次上的实现可能不同时，考虑使用模板方法模式。
 * 定义一个操作中的算法的骨架，而将一些步骤延迟到子类中。
 * 模板方法使得子类可以不改变一个算法的结构即可重定义该算法的某些特定步骤。
 * 
 * 模板方法模式是通过把不变行为搬移到父类，去除子类中的重复代码来体现它的优势。提供了一个很好的代码复用平台。
 * 
 * 当不变的和可变的行为在方法的子类实现中混合到一起的时候，不变的行为就会在子类中重复出现。
 * 通过模板方法模式把这些行为搬移到单一的地方，这样就帮助子类摆脱重复的不变行为的纠缠。
 */
namespace TemplatePattern
{
    internal class Program
    {
        static void Main(string[] args) {
            AbstractClass c;

            c = new ConcreteClassA();
            c.TemplateMethod();

            c = new ConcreteClassB();
            c.TemplateMethod();

            Console.Read();
        }
    }
}
