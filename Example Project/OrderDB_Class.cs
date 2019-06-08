/*
 * Author - Raikhana Urazbaeva 
 * Class - OrderDB Queries for a order table
 * June 2019
 */

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Project
{
    public static class OrderDB_Class
    {
        public static List<OrderClass> GetOrders()
        {
            SqlConnection connection = CompanyDB_Class.GetConnection();
            string selectStatement
                = "SELECT id, date, subtotal, tax, total, status_order_id, client_id "
                + "FROM orders";
            SqlCommand selectcommand =
                new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader custReader =
                    selectcommand.ExecuteReader();

                List<OrderClass> orders = new List<OrderClass>();
                while (custReader.Read())
                {
                    OrderClass order = new OrderClass();
                    order.idOrders = (int)custReader["id"];
                    order.dateOrder = Convert.ToDateTime(custReader["date"]);
                    order.subtotalOrders = Convert.ToDecimal(custReader["subtotal"]);
                    order.taxOrder = Convert.ToDecimal(custReader["tax"]);
                    order.totalOrder = Convert.ToDecimal(custReader["total"]);
                    order.statusOrderId = Convert.ToInt32(custReader["status_order_id"]);
                    order.client_id = Convert.ToInt32(custReader["client_id"]);
                    orders.Add(order);
                }
                custReader.Close();
                return orders;

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
        public static bool AddOrder(OrderClass order, List<Order_Products> products)
        {
            SqlConnection connection = CompanyDB_Class.GetConnection();
            string insertStatement =
                "INSERT INTO orders " +
                "( date, subtotal, tax, total, status_order_id, client_id) " +
                "VALUES ( @date, @subtotal, @tax, @total, @status_order_id, @client_id)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@date", order.dateOrder);
            insertCommand.Parameters.AddWithValue("@subtotal", order.subtotalOrders);
            insertCommand.Parameters.AddWithValue("@tax", order.taxOrder);
            insertCommand.Parameters.AddWithValue("@total", order.totalOrder);
            insertCommand.Parameters.AddWithValue("@status_order_id", order.statusOrderId);
            insertCommand.Parameters.AddWithValue("@client_id", order.client_id);

            try
            {
                connection.Open();
                int count = insertCommand.ExecuteNonQuery();
                if (count > 0)
                {
                    connection.Close();

                    int order_id = Order_Products(); //  method 1                 

                    Insers_Products(products, order_id);// method 2

                    return true;
                }
                else
                {
                    return false;
                }
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

        private static void Insers_Products(List<Order_Products> products, int order_id) //method 2
        {
            foreach (Order_Products product in products)
            {
                SqlConnection connection_Products = CompanyDB_Class.GetConnection();
                string insertStatement_Products = "INSERT INTO orders_products " +
                    "( order_id, product_id, amount ) VALUES ( @order_id, @product_id, @amount)";
                SqlCommand insertCommand_Products = new SqlCommand(insertStatement_Products, connection_Products);
                insertCommand_Products.Parameters.AddWithValue("@order_id", order_id);
                insertCommand_Products.Parameters.AddWithValue("@product_id", product.product_id);
                insertCommand_Products.Parameters.AddWithValue("@amount", product.ammount);

                try
                {
                    connection_Products.Open();
                    int check = insertCommand_Products.ExecuteNonQuery();
                    if (check > 0)
                    {

                    }
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                finally
                {
                    connection_Products.Close();
                }

            }
        }

        private static int Order_Products() //method 1
        {
            int order_id = 0;
            SqlConnection connectionOrderID = CompanyDB_Class.GetConnection();
            string selectStatementOrderID = "SELECT MAX(id) as id FROM orders";
            SqlCommand selectcommandOrderID = new SqlCommand(selectStatementOrderID, connectionOrderID);
            try
            {
                connectionOrderID.Open();
                SqlDataReader order_id_Reader = selectcommandOrderID.ExecuteReader();
                if (order_id_Reader.Read())
                {
                    order_id = Convert.ToInt32(order_id_Reader["id"]);
                }
                order_id_Reader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connectionOrderID.Close();
            }

            return order_id;
        }
        public static List<ProductClass> GetProductByID(int order_id)
        {
            List<ProductClass> products = new List<ProductClass>();
            SqlConnection connection = CompanyDB_Class.GetConnection();
            string selectStatement = "SELECT products.name, products.description, products.cost, orders_products.amount "
                                    + " FROM products "
                                    + " INNER JOIN orders_products ON orders_products.product_id = products.id "
                                    + " WHERE order_id = @order_id";

            SqlCommand selectcommand = new SqlCommand(selectStatement, connection);
            selectcommand.Parameters.AddWithValue("@order_id", order_id);
            try
            {
                connection.Open();
                SqlDataReader custReader = selectcommand.ExecuteReader();

                while (custReader.Read())
                {
                    ProductClass product = new ProductClass();
                    product.nameProduct = custReader["name"].ToString();
                    product.descriptionProduct = custReader["description"].ToString();
                    product.costProduct = Convert.ToDouble(custReader["cost"]);
                    product.ammountProduct = Convert.ToInt32(custReader["amount"]);
                    products.Add(product);
                }
                return products;
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
        public static bool ChangeStatusOrder(OrderClass order)
        {
            SqlConnection connection = CompanyDB_Class.GetConnection();
            string updateStatement =
                "UPDATE  orders SET " +
                "status_order_id = @status_order_id " +
                " WHERE id = @id ";
            SqlCommand updateCommand =
                new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue(
                "@id", order.idOrders);
            updateCommand.Parameters.AddWithValue(
               "@status_order_id", order.statusOrderId);
            try
            {
                connection.Open();
                int count = updateCommand.ExecuteNonQuery();
                if (count > 0)
                    return true;
                else
                    return false;
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
