using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IteratorPattern
{
  /// <summary>
  /// 迭代器抽象类
  /// </summary>
  internal abstract class Iterator
  {
    public abstract object First();
    public abstract object Next();
    public abstract bool IsDone();
    public abstract object CurrentItem();
  }
}
