﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
  /// <summary>
  /// 聚集抽象类
  /// </summary>
  internal abstract class Aggregate
  {
    /// <summary>
    /// 创建迭代器
    /// </summary>
    /// <returns></returns>
    public abstract Iterator CreateIterator();
  }
}
