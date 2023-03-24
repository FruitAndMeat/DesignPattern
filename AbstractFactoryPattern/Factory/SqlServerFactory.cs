using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    internal class SqlServerFactory : IFactory
    {
        public IUser CreateUser() {
            return new SqlServerUser();
        }
        public IDepartment CreateDepartment() {
            return new SqlServerDepartment();
        }
    }
}
