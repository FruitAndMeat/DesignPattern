using System.Configuration;
using System.Reflection;

namespace AbstractFactoryPattern
{
    internal class DataAccess
    {
        private static readonly string db = ConfigurationManager.AppSettings["DB"];
        private static readonly string AssemblyName = "AbstractFactoryPattern";
        //private static readonly string db = "SqlServer";
        //private static readonly string db="Access";
        public static IUser CreateUser() {
            //IUser user = null;
            //switch (db) {
            //    case "SqlServer": user=new SqlServerUser(); break;
            //    case "Access":user = new AccessUser();break;
            //    default:
            //        break;
            //}
            //return user;


            string className = AssemblyName + "." + db + "User";
            return (IUser)Assembly.Load(AssemblyName).CreateInstance(className);
        }

        public static IDepartment CreateDepartment() {
            //IDepartment department = null;
            //switch (db) {
            //    case "SqlServer": department = new SqlServerDepartment(); break;
            //    case "Access": department = new AccessDepartment(); break;
            //    default:
            //        break;
            //}
            //return department;

            string className = AssemblyName + "." + db + "Department";
            return (IDepartment)Assembly.Load(AssemblyName).CreateInstance(className);
        }
    }
}
