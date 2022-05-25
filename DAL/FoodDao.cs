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
    public class FoodDao : BaseDao
    {
        public List<Food> findAllFoodByCategoryId(int categoryId)
        {
            List<Food> foodList = new List<Food>();
            SqlConnection connection = null;
            try
            {
                String query = "SELECT * FROM dbo.Food WHERE category_id = " + categoryId;
                connection = openConnection();

                SqlCommand command = new SqlCommand(query, connection);

                DataTable dataTable = new DataTable();

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    Food food = new Food((int)row["id"], (int)row["category_id"], (String)row["name"], (String)row["price"]);
                    foodList.Add(food);
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
            return foodList;
        }
    }
}
