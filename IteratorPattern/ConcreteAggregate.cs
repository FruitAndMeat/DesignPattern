using System.Collections.Generic;

namespace IteratorPattern
{
  internal class ConcreteAggregate : Aggregate
  {
    //声明一个IList泛型变量，用于存储聚合对象，用ArratList同样可以实现。
    private IList<object> items=new List<object>();

    public override Iterator CreateIterator() {
      return new ConcreteIterator(this);      
    }
    /// <summary>
    /// 返回聚集总个数
    /// </summary>
    public int Count { get { return items.Count; } }
    /// <summary>
    /// 声明一个索引器
    /// </summary>
    public object this[int index] {
      get 
        { 
        return items[index]; 
      }
      set { items.Insert(index,value); }
    }
  }
}