/*
 * Author - Raikhana Urazbaeva 
 * Class - Product_statusDB Queries for a product_status table
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
    public static class Product_statusDBClass
    {
        public static List<ProductStatusClass> GetProduct_status()
        {
            SqlConnection connection = CompanyDB_Class.GetConnection();
            string selectStatement
                = "SELECT id, status "
                + "FROM product_status";
            SqlCommand selectcommand =
                new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader custReader =
                    selectcommand.ExecuteReader();

                List<ProductStatusClass> status = new List<ProductStatusClass>();
                while (custReader.Read())
                {
                    ProductStatusClass productStatus = new ProductStatusClass();
                    productStatus.id = (int)custReader["id"];
                    productStatus.status = custReader["status"].ToString();
                    status.Add(productStatus);
                }
                custReader.Close();
                return status;

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
