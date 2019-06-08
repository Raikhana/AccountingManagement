/*
 * Author - Raikhana Urazbaeva 
 * Class - Products DB Queries for a product table
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
    public static class ProductDB_Class
    {
        public static List<ProductClass> GetProducts()
        {
            SqlConnection connection = CompanyDB_Class.GetConnection();
            string selectStatement
                = "SELECT id, name, description, created, updated, cost, status "
                + "FROM products";
            SqlCommand selectcommand =
                new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader custReader =
                    selectcommand.ExecuteReader();

                List<ProductClass> products = new List<ProductClass>();
                while (custReader.Read())
                {
                    ProductClass product = new ProductClass();
                    product.idProduct = (int)custReader["id"];
                    product.nameProduct = custReader["name"].ToString();
                    product.descriptionProduct = custReader["description"].ToString();
                    product.updatedProduct = Convert.ToDateTime(custReader["updated"]);
                    product.createdProduct = Convert.ToDateTime(custReader["created"]);
                    product.costProduct = Convert.ToDouble(custReader["cost"]);
                    product.idStatusProduct = Convert.ToInt32(custReader["status"]);
                    products.Add(product);
                }
                custReader.Close();
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
        public static bool AddProduct(ProductClass product)
        {
            SqlConnection connection = CompanyDB_Class.GetConnection();
            string insertStatement =
                "INSERT INTO products " +
                "( name, description, created, updated, cost, status ) " +
                "VALUES ( @name, @description, @created, @updated, @cost, @status )";
            SqlCommand insertCommand =
                new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue(
                "@name", product.nameProduct);
            insertCommand.Parameters.AddWithValue(
                "@description", product.descriptionProduct);
            insertCommand.Parameters.AddWithValue(
                "@created", product.createdProduct);
            insertCommand.Parameters.AddWithValue(
                "@updated", product.updatedProduct);
            insertCommand.Parameters.AddWithValue(
                "@cost", product.costProduct);
            insertCommand.Parameters.AddWithValue(
                "@status", product.idStatusProduct);
            try
            {
                connection.Open();
                int count = insertCommand.ExecuteNonQuery();
                if (count > 0)
                {
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
        public static bool ModifyProduct(ProductClass product)
        {
            SqlConnection connection = CompanyDB_Class.GetConnection();
            string updateStatement =
                "UPDATE  products SET " +
                "name = @name, " +
                "description = @description, " +
                "updated = @updated, " +
                "cost = @cost, " +
                "status = @status " +
                " WHERE id = @id "; 
            SqlCommand updateCommand =
                new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue(
                "@id", product.idProduct);
            updateCommand.Parameters.AddWithValue(
               "@name", product.nameProduct);
            updateCommand.Parameters.AddWithValue(
               "@description", product.descriptionProduct);
            updateCommand.Parameters.AddWithValue(
               "@updated", product.updatedProduct);
            updateCommand.Parameters.AddWithValue(
               "@cost", product.costProduct);
            updateCommand.Parameters.AddWithValue(
               "@status", product.idStatusProduct);
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
        public static bool DeleteProduct(int id)
        {
            SqlConnection connection = CompanyDB_Class.GetConnection();
            string deleteStatement =
                "DELETE FROM products " +
                "WHERE id = @id";
            SqlCommand deleteCommand =
                new SqlCommand(deleteStatement, connection);
            deleteCommand.Parameters.AddWithValue("@id", id);
            try
            {
                connection.Open();
                int count = deleteCommand.ExecuteNonQuery();
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
        public static List<ProductClass> GetProductsName()
        {
            SqlConnection connection = CompanyDB_Class.GetConnection();
            string selectStatement
                = "SELECT id, name, cost "
                + "FROM products";
            SqlCommand selectcommand =
                new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader custReader =
                    selectcommand.ExecuteReader();

                List<ProductClass> products = new List<ProductClass>();
                while (custReader.Read())
                {
                    ProductClass product = new ProductClass();
                    product.idProduct = (int)custReader["id"];
                    product.nameProduct = custReader["name"].ToString();
                    product.costProduct = Convert.ToDouble(custReader["cost"]);
                    products.Add(product);
                }
                custReader.Close();
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

        public static List<ProductClass> SearchProduct(string search)          ////////////////////////////
        {
            SqlConnection connection = CompanyDB_Class.GetConnection();
            string selectStatement
                = "SELECT id, name, description, created, updated, cost, status "
                + "FROM products "
                + "WHERE name = @name" +
                   " OR cost = @cost";
            SqlCommand selectcommand =
                new SqlCommand(selectStatement, connection);
            selectcommand.Parameters.AddWithValue("@name", search);
            selectcommand.Parameters.AddWithValue("@cost", search);
            try
            {
                connection.Open();
                SqlDataReader custReader =
                    selectcommand.ExecuteReader();
                List<ProductClass> products = new List<ProductClass>();
                while (custReader.Read())
                {
                    ProductClass product = new ProductClass();
                    product.idProduct = (int)custReader["id"];
                    product.nameProduct = custReader["name"].ToString();
                    product.descriptionProduct = custReader["description"].ToString();
                    product.updatedProduct = Convert.ToDateTime(custReader["updated"]);
                    product.createdProduct = Convert.ToDateTime(custReader["created"]);
                    product.costProduct = Convert.ToDouble(custReader["cost"]);
                    product.idStatusProduct = Convert.ToInt32(custReader["status"]);
                    products.Add(product);

                }
                custReader.Close();
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
    }
}
