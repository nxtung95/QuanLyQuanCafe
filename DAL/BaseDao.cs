using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BaseDao
    {
        private String connectionString = "Data Source=DESKTOP-0K43S07\\TUNGNX;Initial Catalog=ql_quancafe;Persist Security Info=True;User ID=sa;Password=firstTime95";

        public SqlConnection openConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }

        public void closeConnection(SqlConnection connection)
        {
            if (connection != null)
            {
                connection.Close();
            }
        }
    }
}
