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
    public class TableDao : BaseDao
    {
        public List<Table> getAllTable()
        {
            List <Table> tableList = new List<Table>();
            SqlConnection connection = null;
            try
            {
                String query = "SELECT * FROM [dbo].[Table]";
                connection = openConnection();
                
                SqlCommand command = new SqlCommand(query, connection);

                DataTable dataTable = new DataTable();

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    Table table = new Table((int) row["id"], (String) row["name"], (int) row["status"]);
                    tableList.Add(table);
                }

            } catch (Exception ex)
            {
                ex.StackTrace.ToString();
            } finally
            {
                closeConnection(connection);
            }
            return tableList;
        }

        public bool delete(int tableId)
        {
            bool result;
            SqlConnection connection = null;
            try
            {
                String query = "DELETE FROM [dbo].[Table] WHERE id = " + tableId;
                connection = openConnection();

                SqlCommand command = new SqlCommand(query, connection);

                command.ExecuteNonQuery();

                result = true;
            }
            catch (Exception ex)
            {
                ex.StackTrace.ToString();
                result = false;
            }
            finally
            {
                closeConnection(connection);
            }
            return result;
        }

        public bool add(Table table)
        {
            bool result;
            SqlConnection connection = null;
            try
            {
                String query = "INSERT INTO [dbo].[Table](name, status) VALUES(@name, @status)";
                connection = openConnection();

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@name", table.Name);
                command.Parameters.AddWithValue("@status", table.Status);
                command.ExecuteNonQuery();

                result = true;
            }
            catch (Exception ex)
            {
                ex.StackTrace.ToString();
                result = false;
            }
            finally
            {
                closeConnection(connection);
            }
            return result;
        }

        public string getNextTableName()
        {
            String nextTableName = "";
            SqlConnection connection = null;
            try
            {
                String query = "SELECT * FROM [dbo].[Table] ORDER BY ID DESC";
                connection = openConnection();

                SqlCommand command = new SqlCommand(query, connection);

                DataTable dataTable = new DataTable();

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);

                nextTableName = "Bàn " + dataTable.Rows[0]["id"];
            }
            catch (Exception ex)
            {
                ex.StackTrace.ToString();
            }
            finally
            {
                closeConnection(connection);
            }
            return nextTableName;
        }
    }
}
