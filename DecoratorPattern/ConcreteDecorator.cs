using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    /// <summary>
    /// 这是ConcreteDecorator类
    /// </summary>
    internal class TShirts : Finery
    {
        public override void Show() {
            Console.WriteLine("大T恤");
            base.Show();
        }
    }
    internal class BigTrouser:Finery
    {
        public override void Show() {
            Console.WriteLine("垮裤");
            base.Show();
        }
    }
    internal class Sneakers : Finery
    {
        public override void Show() {
            Console.WriteLine("破球鞋");
            base.Show();
        }
    }
    internal class Suit : Finery
    {
        public override void Show() {
            Console.WriteLine("西装");
            base.Show();
        }
    }
    internal class Tie : Finery
    {
        public override void Show() {
            Console.WriteLine("领带");
            base.Show();
        }
    }
    internal class LeatherShoes : Finery
    {
        public override void Show() {
            Console.WriteLine("皮鞋");
            base.Show();
        }
    }
}
