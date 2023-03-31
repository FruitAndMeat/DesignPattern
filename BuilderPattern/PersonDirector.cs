using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    //Director是建造指挥者，它是构建一个使用Builder接口的对象
    /// <summary>
    /// 指挥者类
    /// </summary>
    internal class PersonDirector
    {
        private PersonBuilder pb;
        //用户告诉指挥者，我需要什么样的小人。
        public PersonDirector(PersonBuilder pb) {
            this.pb = pb;
        }
        public void CreatePerson() {
            pb.BuildHead();
            pb.BuildBody();
            pb.BuildArmLeft();
            pb.BuildArmRight();
            pb.BuildLegLeft();
            pb.BuildLegRight();
        }
    }
}
