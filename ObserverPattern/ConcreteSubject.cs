using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    /// <summary>
    /// 具体主题或具体通知者，将有关状态存入具体观察者对象；
    /// 在具体主题的内部状态改变时，给所有登记过的观察者发出通知。
    /// 具体主题角色通常用一个具体子类实现。
    /// </summary>
    internal class ConcreteSubject:Subject
    {
        private string subjectState;

        //具体被观察者状态
        public string SubjectState {
            get { return subjectState; }
            set { subjectState = value; }
        }
    }
}
