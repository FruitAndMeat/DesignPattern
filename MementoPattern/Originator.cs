using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    /// <summary>
    /// 游戏角色类，也就是备忘录模式中的Originator(发起人)。
    /// </summary>
    /// <remarks>负责创建一个备忘录Memento,用以记录当前时刻它的内部状态。并可使用备忘录恢复内部状态
    /// Originator可根据需要决定Memento存储Originator的哪些内部状态。
    /// </remarks>
    internal class GameRole 
    {
        private int vit;
        /// <summary>
        /// 生命力
        /// </summary>
        public int Vitality {
            get { return vit; }
            set { vit = value; }
        }

        private int atk;
        /// <summary>
        /// 攻击力
        /// </summary>
        public int Attack {
            get { return atk; }
            set { atk = value; }
        }

        private int def;
        /// <summary>
        /// 防御力
        /// </summary>
        public int Defense {
            get { return def; }
            set { def = value; }
        }
        /// <summary>
        /// 状态显示
        /// </summary>
        public void StateDisplay() {
            Console.WriteLine("角色当前状态：");
            Console.WriteLine("体力：{0}", this.vit);
            Console.WriteLine("攻击力：{0}", this.atk);
            Console.WriteLine("防御力：{0}", this.def);
            Console.WriteLine("");
        }
        /// <summary>
        /// 获得初始状态
        /// </summary>
        public void GetInitState() {
            this.vit = 100;
            this.atk = 100;
            this.def = 100;
        }
        /// <summary>
        /// 战斗
        /// </summary>
        public void Fight() {
            this.vit = 0;
            this.atk = 0;
            this.def = 0;
        }
        /// <summary>
        /// 保存角色状态
        /// </summary>
        /// <returns></returns>
        public RoleStateMemento SaveState() {
            return (new RoleStateMemento(vit, atk, def));
        }
        /// <summary>
        /// 恢复角色状态
        /// </summary>
        /// <param name="memento"></param>
        public void RecoveryState(RoleStateMemento memento) {
            this.vit=memento.Vitality;
            this.atk = memento.Attack;
            this.def = memento.Defense;
        
        }
    }
}
