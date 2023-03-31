namespace MementoPattern
{
    /// <summary>
    /// Memento:备忘录。
    /// </summary>
    /// <remarks>
    /// 负责存储Originator对象内部的状态，并可防止Originator以外的其他对象访问备忘录Memento.
    /// 备忘录有两个接口，Caretaker只能看到备忘录的窄接口，它只能将备忘录传递给其他对象。
    /// Originator能够看到一个宽接口，允许它访问返回到先前状态所需的所有数据。
    /// </remarks>
    public class RoleStateMemento
    {
        public RoleStateMemento(int vit, int atk, int def) {
            Vitality = vit;
            Attack = atk;
            Defense = def;
        }

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
    }
}