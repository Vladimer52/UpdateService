using System.Data.SqlClient;

namespace UpdateService
{
    class DbUtils
    {
        public static SqlConnection GetDbConnection()
        {
            string dataSource = @"(LocalDB)\MSSQLLocalDB";
            string dataBase = "datadb";
            string username = "admin";
            string password = "admin";

            return DbSqlServerUtils.GetDBConnection(dataSource, dataBase, username, password);
        }

    }
}
