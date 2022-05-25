using DAL.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategoryDao : BaseDao
    {
        public List<Category> getAllCategory()
        {
            List<Category> categoryList = new List<Category>();
            SqlConnection connection = null;
            try
            {
                String query = "SELECT * FROM [dbo].[Category]";
                connection = openConnection();

                SqlCommand command = new SqlCommand(query, connection);

                DataTable dataTable = new DataTable();

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    Category category = new Category((int)row["id"], (String)row["name"]);
                    categoryList.Add(category);
                }

            }
            catch (Exception ex)
            {
                ex.StackTrace.ToString();
            }
            finally
            {
                closeConnection(connection);
            }
            return categoryList;
        }
    }
}
