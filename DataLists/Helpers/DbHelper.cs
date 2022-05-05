using System;
using System.Data.SqlClient;

namespace DataLists.Helpers
{
    public class DbHelper
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;");
        }
    }
}