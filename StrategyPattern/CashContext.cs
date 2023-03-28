using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class CashContext
    {
        private CashSuper cs;
        public CashContext(CashSuper cs) {
            this.cs = cs;
        }

        public double GetResult(double money) {
            return cs.acceptCash(money);
        }
    }
}
