/*
 * Author - Raikhana Urazbaeva 
 * Class - To get status of order from a orders_status table
 * June 2019
 */

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Project
{
    public static class ProductOrderStatusClassDB //ProductStatusClassDB
    {
        public static List<OrderStatusClass> GetOrderStatus()
        {
            SqlConnection connection = CompanyDB_Class.GetConnection();
            string selectStatement
                = "SELECT id, name "
                + "FROM orders_status";
            SqlCommand selectcommand =
                new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader custReader =
                    selectcommand.ExecuteReader();

                List<OrderStatusClass> orders_status = new List<OrderStatusClass>();
                while (custReader.Read())
                {
                    OrderStatusClass ordersStatus = new OrderStatusClass();
                    ordersStatus.idOrderStatus = (int)custReader["id"];
                    ordersStatus.nameOrderStatus = custReader["name"].ToString();
                    orders_status.Add(ordersStatus);
                }
                custReader.Close();
                return orders_status;

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
