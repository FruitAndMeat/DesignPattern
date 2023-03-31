using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
/* 适配器模式：将一个类的接口转换成客户希望的另一个接口。分为两种类型：类适配器模式和对象适配器模式
 * 适配器模式使得原本由于接口不兼容而不能一起工作的那些类可以一起工作。
 * 在软件开发中，系统的数据和行为都正确，但接口不符时，我们应该考虑使用适配器，目的是使控制范围之外的一个原有对象与
 * 某个接口匹配。适配器模式主要应用于希望复用一些现存的类，但是接口又和复用环境要求不一致的情况。
 * 比如在需要对早期代码复用一些功能等应用上很有实际价值。
 * 
 * 类适配器模式：通过多重继承对一个接口与另一个接口进行匹配，而C#不支持多重继承，（C++支持），也就是一个类只有一个父类。
 * 所以这里是对象适配器模式。
 * 
 * 使用场景：在想使用一个已经存在的类，但如果他的接口，也就是它的方法和你要求不相同时，就考虑使用。
 * 即两个类所做的事情相同或相似，但是具有不同的接口时要使用它。 这样使得客户代码可以统一调用同一接口，可以更简单、直接、紧凑。
 * 一般是在双方都不太容易修改的时候再使用适配器模式适配，即项目后期维护的情况下。也有考虑使用第三方组件时使用此模式。
 * 
 * 适配器在.Net中的使用，即DataAdapter。DataAdapter用作DataSet和数据源之间的适配器以便检索和保存数据。
 * DataAdapter通过映射Fill(这改变了DataSet中的数据以便与数据源中的数据相匹配）和Update(这改变了数据源中的数据
 * 以便与DataSet中的数据相匹配）来提供这一适配器。由于数据源可能来自不同的数据库，但我们希望得到统一的DataSet.此时使用
 * DataAdapter就是比较好的方式。
 * 
 */
namespace AdapterPattern
{
    internal class Program
    {
        static void Main(string[] args) {

            Player b = new Forwards("巴蒂尔");
            b.Attack();

            Player m = new Guards("麦克格雷迪");
            m.Attack();

            //翻译者告诉姚明，教练要求你既要“进攻”又要“防守”
            Player ym = new Translator("姚明");
            ym.Attack();
            ym.Defense();

            Console.Read();
        }
    }
    /// <summary>
    /// 抽象球员类
    /// </summary>
    abstract class Player {
        protected string name;
        public Player(string name) {
            this.name = name;
        }

        public abstract void Attack();
        public abstract void Defense();
    }
    //前锋
    class Forwards : Player
    {
        public Forwards(string name):base(name) {

        }
        public override void Attack() {
            Console.WriteLine($"前锋{name}进攻。");
        }

        public override void Defense() {
            Console.WriteLine($"前锋{name}防守。");
        }
    }
    //中锋
    class Center : Player
    {
        public Center(string name) : base(name) {

        }
        public override void Attack() {
            Console.WriteLine($"中锋{name}进攻。");
        }

        public override void Defense() {
            Console.WriteLine($"中锋{name}防守。");
        }
    }
    //后卫
    class Guards : Player
    {
        public Guards(string name) : base(name) {

        }
        public override void Attack() {
            Console.WriteLine($"后卫{name}进攻。");
        }

        public override void Defense() {
            Console.WriteLine($"后卫{name}防守。");
        }
    }
}
