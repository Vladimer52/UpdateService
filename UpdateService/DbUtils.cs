using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace UpdateService
{
    class DbUtils
    {
        public static SqlConnection GetDbConnection()
        {
            string dataSource = @"(LocalDB)\MSSQLLocalDB";
            string dataBase = "users";
            string username = "admin";
            string password = "admin";

            return DbSqlServerUtils.GetDBConnection(dataSource, dataBase, username, password);
        }

    }
}
