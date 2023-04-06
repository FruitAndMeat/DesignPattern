using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
  internal class ConcreteIterator : Iterator
  {
    //定义了一个具体聚集对象
    private ConcreteAggregate aggregate;
    private int current=0;
    /// <summary>
    /// 初始化时将具体的聚集对象传入
    /// </summary>
    /// <param name="aggregate"></param>
    public ConcreteIterator(ConcreteAggregate aggregate) {
      this.aggregate = aggregate;
    }
    /// <summary>
    /// 返回当前的聚集对象
    /// </summary>
    /// <returns></returns>
    public override object CurrentItem() {
      return aggregate[current];
    }
    /// <summary>
    /// 得到聚集的第一个对象
    /// </summary>
    /// <returns></returns>
    public override object First() {
      return aggregate[0];
    }

    /// <summary>
    /// 判断是否遍历到结尾，到结尾返回true。
    /// </summary>
    /// <returns></returns>
    public override bool IsDone() {
      return current>=aggregate.Count?true:false;
    }

    
    /// <summary>
    /// 得到聚集的下一个对象
    /// </summary>
    /// <returns></returns>
    public override object Next() {
      object ret = null;
      current++;
      if (current<aggregate.Count) {
        ret=aggregate[current];
      }
      return ret;
    }
  }
}
