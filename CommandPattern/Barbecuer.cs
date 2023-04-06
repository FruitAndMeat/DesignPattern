using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
  /// <summary>
  /// 烤肉师傅。即是Receiver类，知道如何实施和执行一个与请求相关的操作，任何类都可能作为一个接收者。
  /// </summary>
  internal class Barbecuer
  {
    /// <summary>
    /// 烤羊肉串
    /// </summary>
    public void BakeMutton() {
      Console.WriteLine("烤羊肉串");
    }
    /// <summary>
    /// 烤鸡翅
    /// </summary>
    public void BakeChickenWing() {
      Console.WriteLine("烤鸡翅");
    }


  }
}
