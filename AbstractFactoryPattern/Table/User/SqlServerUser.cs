using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    internal class SqlServerUser : IUser
    {
        public User GetUser(int id) {
            Console.WriteLine("在SQL Server中根据Id得到User表一条记录");
            return null;
        }

        public void Insert(User user) {
            Console.WriteLine("在SQL Server中给User表增加一条记录");
        }
    }
}
