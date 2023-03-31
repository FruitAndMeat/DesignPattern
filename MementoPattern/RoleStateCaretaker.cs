using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    /// <summary>
    /// Caretaker，管理者类
    /// </summary>
    /// <remarks>负责保存备忘录Memento,不能对备忘录的内容进行操作或检查。</remarks>
    internal class RoleStateCaretaker
    {
        private RoleStateMemento memento;

        public RoleStateMemento Memento {
            get { return memento; }
            set { memento = value; }
        }

    }
}
