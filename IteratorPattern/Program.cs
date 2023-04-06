using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*迭代器模式：提供一种方法顺序访问一个聚合对象的各个元素，而又不暴露该对象的内部表示。
 * 当需要访问一个聚集对象，而且不管是这些对象是什么都需要遍历的时候，就考虑使用迭代器模式。
 * 或者需要对聚集有多种方式遍历时，可以考虑用迭代器模式。
 * 为遍历不同的聚集结构提供如开始、下一个、是否结束、当前哪一项等统一的接口。
 * 
 * 实际使用是不需要这么麻烦的，.net框架已经准备了IEnumrator接口支持对非泛型集合的简单迭代。
 * 但是，尽管我们不需要显式的引用迭代器，但系统本身还是通过迭代器来实现遍历的。
 * 总的来说，迭代器模式就是分离了集合对象的遍历行为，抽象出一个迭代器类来负责，这样即可以做到不暴露集合的内部结构，
 * 又可让外部代码透明地访问集合内部的数据。
 */
namespace IteratorPattern
{
  internal class Program
  {
    static void Main(string[] args) {
      ConcreteAggregate a = new ConcreteAggregate();
      a[0] = "大鸟";
      a[1] = "小菜";
      a[2] = "行李";
      a[3] = "老外";
      a[4] = "公交内部员工";
      a[5] = "小偷";
      Iterator i = new ConcreteIteratorDesc(a);
      object item = i.First();
      while (!i.IsDone()) {
        Console.WriteLine("{0}请买票！",i.CurrentItem());
        i.Next();
      }
      Console.Read();
    }
  }
}
