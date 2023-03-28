using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal  class CashReturn:CashSuper
    {
        private double moneyCondition = 0.0d;
        private double moneyReturn = 0.0d;
        public CashReturn(string moneyCondition,string moneyReturn) {
            this.moneyReturn =double.Parse( moneyReturn);
            this.moneyCondition = double.Parse( moneyCondition);
        }

        public override double acceptCash(double money) {
            double result=money;
            if (money>moneyCondition) {
                result=money-Math.Floor(money/moneyCondition)*moneyReturn;
            }
            return result;
        }
    }
}
