using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*外观模式：为子系统中的一组接口提供一个一致的界面，此模式定义了一个高层接口，这个接口使得这一子系统更加容易使用。
 * 应用场景：
 *  首先，在设计初期阶段，应该有意识的将不同的两个层分离，比如在三层架构中的层与层之间建立外观Facade.
 * 这样可以为复杂的子系统提供一个简单的接口，使得耦合大大的降低。
 *  其次，在开发阶段，子系统往往因为不断的重构演化而变得越来越复杂。大多数的模式使用时也都会产生很多很小的类，
 * 这本是好事，但也给外部调用它们的应用程序带来了使用上的困难，增加外观Facade可以提供一个简单的接口，
 * 减少它们之间的依赖。
 *  第三，在维护一个遗留的大型系统时，可能这个系统已经非常难以维护和扩展了。但因为它包含非常重要的功能，
 *  新的需求开发必须依赖于他。此时用外观模式也是非常合适的。可以为新系统开发一个外观Facade类，来提供设计粗糙
 *  或高度复杂的遗留代码的比较清晰的接口，让新系统与Facade对象交互，Facade与遗留代码交互所有复杂的工作。
 */
namespace FacadePattern
{
    internal class Program
    {
        static void Main(string[] args) {

                Facade facade = new Facade();
            facade.MethodA();
            facade.MethodB();

            Console.Read();
        }
    }
    /// <summary>
    /// 外观类
    /// </summary>
    internal class Facade {
        SubSystemOne one;
        SubSystemTwo two;
        SubSystemThree three;
        SubSystemFour four;
        public Facade() {
            one= new SubSystemOne();
            two= new SubSystemTwo();
            three= new SubSystemThree();
            four= new SubSystemFour();
        }

        public void MethodA() {
            Console.WriteLine("\n 方法组A（） ----");
            one.MethondOne();
            two.MethondTwo();
            four.MethondFour();
        }
        public void MethodB() {
            Console.WriteLine("\n 方法组B（） ----");
            
            two.MethondTwo();
            three.MethondThree();
        }
    }

    #region 子类
    internal class SubSystemOne
    {
        public void MethondOne() {
            Console.WriteLine(" 子系统方法一");
        }
    }
    internal class SubSystemTwo
    {
        public void MethondTwo() {
            Console.WriteLine(" 子系统方法二");
        }
    }
    internal class SubSystemThree
    {
        public void MethondThree() {
            Console.WriteLine(" 子系统方法三");
        }
    }
    internal class SubSystemFour
    {
        public void MethondFour() {
            Console.WriteLine(" 子系统方法四");
        }
    } 
    #endregion
}
