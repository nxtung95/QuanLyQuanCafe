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
    public class BillDao : BaseDao
    {
        public List<Menu> getMenuByTableId(int tableId)
        {
            List<Menu> menus = new List<Menu>();
            SqlConnection connection = null;
            try
            {
                String query = "SELECT c.name, c.price, b.quantity, (b.quantity * c.price) as totalPrice FROM dbo.Bill a " +
                    "INNER JOIN dbo.Bill_Detail b ON a.id = b.bill_id " +
                    "INNER JOIN dbo.Food c ON b.food_id = c.id " +
                    "WHERE a.table_id = " + tableId;
                connection = openConnection();

                SqlCommand command = new SqlCommand(query, connection);

                DataTable dataTable = new DataTable();

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    Menu menu = new Menu((String)row["name"], (String)row["price"], (int)row["quantity"], ((int)row["totalPrice"]).ToString());
                    menus.Add(menu);
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
            return menus;
        }

        public BillDetail checkExistFoodBillDetail(int billId, int foodId)
        {
            BillDetail billDetail = null;
            SqlConnection connection = null;
            try
            {
                String query = "SELECT * FROM dbo.Bill_Detail where bill_id = " + billId + " AND food_id = " + foodId;
                connection = openConnection();

                SqlCommand command = new SqlCommand(query, connection);

                DataTable dataTable = new DataTable();

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    int quantity = (int)dataTable.Rows[0]["quantity"];

                    billDetail = new BillDetail();
                    billDetail.Quantity = quantity;
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
            return billDetail;
        }

        public bool insertBillDetail(int billId, int foodId, int soLuong)
        {
            bool result;
            SqlConnection connection = null;
            try
            {
                String query = "INSERT INTO dbo.Bill_Detail(bill_id, food_id, quantity) VALUES(@billId, @foodId, @quantity)";
                connection = openConnection();

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@billId", billId);
                command.Parameters.AddWithValue("@foodId", foodId);
                command.Parameters.AddWithValue("@quantity", soLuong);
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

        public bool updateBillDetail(int billId, int foodId, int soLuong)
        {
            bool result;
            SqlConnection connection = null;
            try
            {
                String query = "UPDATE dbo.Bill_Detail SET quantity = @quantity WHERE bill_id = @billId AND food_id = @foodId";
                connection = openConnection();

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@quantity", soLuong);
                command.Parameters.AddWithValue("@billId", billId);
                command.Parameters.AddWithValue("@foodId", foodId);
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

        public Bill getBillByTableId(int tableId)
        {
            Bill bill = null;
            SqlConnection connection = null;
            try
            {
                String query = "SELECT * FROM dbo.Bill where status = 0 AND table_id = " + tableId;
                connection = openConnection();

                SqlCommand command = new SqlCommand(query, connection);

                DataTable dataTable = new DataTable();

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    int billId = (int)dataTable.Rows[0]["id"];

                    bill = new Bill();
                    bill.Id = billId;
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
            return bill;
        }

        public bool addBillWithoutActiveTable(int foodId, Bill bill, int soLuong)
        {
            bool result;
            SqlConnection connection = null;
            try
            {
                String query = "INSERT INTO dbo.Bill(table_id, check_in, check_out, status) output INSERTED.ID VALUES (@tableId, @checkIn, @checkOut, @status)";
                connection = openConnection();

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@tableId", bill.TableId);
                command.Parameters.AddWithValue("@checkIn", bill.CheckIn);
                command.Parameters.AddWithValue("@checkOut", bill.CheckOut);
                command.Parameters.AddWithValue("@status", bill.Status);

                int billId = (int)command.ExecuteScalar();

                query = "INSERT INTO dbo.Bill_Detail(bill_id, food_id, quantity) VALUES (@billId, @foodId, @quantity)";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@billId", billId);
                command.Parameters.AddWithValue("@foodId", foodId);
                command.Parameters.AddWithValue("@quantity", soLuong);
                command.ExecuteNonQuery();

                query = "UPDATE [dbo].[Table] SET status = 1 WHERE id = " + bill.TableId;
                command = new SqlCommand(query, connection);
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
    }
}
