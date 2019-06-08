/*
 * Author - Raikhana Urazbaeva 
 * Class - ClientDB Queries for a client table
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
    public static class ClientDB_Class
    {
        public static List<ClientClass> GetClients()
        {
            SqlConnection connection = CompanyDB_Class.GetConnection();
            string selectStatement
                = "SELECT id, first_name, last_name, address, city, country, postal_code, " +
                  "company, phone, payment, email, created, updated "
                + "FROM clients";
            SqlCommand selectcommand =
                new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader custReader =
                    selectcommand.ExecuteReader();

                List<ClientClass> clients = new List<ClientClass>();
                while (custReader.Read())
                {
                    ClientClass client = new ClientClass();
                    client.idClient = (int)custReader["id"];
                    client.firstNameClient = custReader["first_name"].ToString();
                    client.lastNameClient = custReader["last_name"].ToString();
                    client.addressClient = custReader["address"].ToString();
                    client.cityClient = custReader["city"].ToString();
                    client.countryClient = custReader["country"].ToString();
                    client.postalCodeClient = custReader["postal_code"].ToString();
                    client.companyClient = custReader["company"].ToString();
                    client.phoneClient = custReader["phone"].ToString();
                    client.paymentClient = custReader["payment"].ToString();
                    client.emailClient = custReader["email"].ToString();
                    client.updatedClient = Convert.ToDateTime(custReader["updated"]);
                    client.createdClient = Convert.ToDateTime(custReader["created"]);
                    clients.Add(client);
                }
                custReader.Close();
                return clients;
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
        public static bool AddClient(ClientClass client)
        {
            SqlConnection connection = CompanyDB_Class.GetConnection();
            string insertStatement =
                "INSERT INTO clients " +
                "( first_name, last_name, address, city, country, postal_code, " +
                  "company, phone, payment, email, created, updated ) " +
                "VALUES ( @first_name, @last_name, @address, @city, @country, @postal_code, " +
                  "@company, @phone, @payment, @email, @created, @updated )";
            SqlCommand insertCommand =
                new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue(
               "@first_name", client.firstNameClient);
            insertCommand.Parameters.AddWithValue(
                "@last_name", client.lastNameClient);
            insertCommand.Parameters.AddWithValue(
                "@address", client.addressClient);
            insertCommand.Parameters.AddWithValue(
                "@city", client.cityClient);
            insertCommand.Parameters.AddWithValue(
                "@country", client.countryClient);
            insertCommand.Parameters.AddWithValue(
                "@postal_code", client.postalCodeClient);
            insertCommand.Parameters.AddWithValue(
                "@company", client.companyClient);
            insertCommand.Parameters.AddWithValue(
                "@phone", client.phoneClient);
            insertCommand.Parameters.AddWithValue(
                "@payment", client.paymentClient);
           insertCommand.Parameters.AddWithValue(
                "@email", client.emailClient);
            insertCommand.Parameters.AddWithValue(
               "@created", client.createdClient);
            insertCommand.Parameters.AddWithValue(
                "@updated", client.updatedClient);
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
        public static bool ModifyClient(ClientClass client)
        {
            SqlConnection connection = CompanyDB_Class.GetConnection();
            string updateStatement =
                "UPDATE clients SET " +
                "first_name = @first_name, " +
                "last_name = @last_name, " +
                "address = @address, " +
                "city = @city, " +
                "country = @country, " +
                "postal_code = @postal_code, " + 
                "company = @company, " +
                "phone = @phone, " +
                "payment = @payment, " +
                "email = @email, " +
                "created = @created, " +
                "updated = @updated " +
                " WHERE id = @id ";
            SqlCommand updateCommand =
                new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue(
                "@id", client.idClient);
            updateCommand.Parameters.AddWithValue(
               "@first_name", client.firstNameClient);
            updateCommand.Parameters.AddWithValue(
               "@last_name", client.lastNameClient);
            updateCommand.Parameters.AddWithValue(
               "@address", client.addressClient);
            updateCommand.Parameters.AddWithValue(
               "@city", client.cityClient);
            updateCommand.Parameters.AddWithValue(
               "@country", client.countryClient);
            updateCommand.Parameters.AddWithValue(
               "@postal_code", client.postalCodeClient);
            updateCommand.Parameters.AddWithValue(
               "@company", client.companyClient);
            updateCommand.Parameters.AddWithValue(
               "@phone", client.phoneClient);
            updateCommand.Parameters.AddWithValue(
               "@payment", client.paymentClient);
            updateCommand.Parameters.AddWithValue(
               "@email", client.emailClient);
            updateCommand.Parameters.AddWithValue(
               "@created", client.createdClient);
            updateCommand.Parameters.AddWithValue(
               "@updated", client.updatedClient);
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

        public static List<ClientClass> SearchClient(string search)       
        {
            SqlConnection connection = CompanyDB_Class.GetConnection();
            string selectStatement
                = "SELECT id, first_name, last_name, address, city, country, postal_code, " +
                  "company, phone, payment, email, created, updated "
                + "FROM clients "
                + "WHERE last_name = @last_name" +
                    " OR first_name = @first_name" +
                    " OR email = @email";
            SqlCommand selectcommand =
                new SqlCommand(selectStatement, connection);
            selectcommand.Parameters.AddWithValue("@last_name", search);
            selectcommand.Parameters.AddWithValue("@first_name", search);
            selectcommand.Parameters.AddWithValue("@email", search);
            try
            {
                connection.Open();
                SqlDataReader custReader =
                    selectcommand.ExecuteReader();
                List<ClientClass> clients = new List<ClientClass>();
                while (custReader.Read())
                {

                    ClientClass client = new ClientClass();
                    client.idClient = (int)custReader["id"];
                    client.firstNameClient = custReader["first_name"].ToString();
                    client.lastNameClient = custReader["last_name"].ToString();
                    client.addressClient = custReader["address"].ToString();
                    client.cityClient = custReader["city"].ToString();
                    client.countryClient = custReader["country"].ToString();
                    client.postalCodeClient = custReader["postal_code"].ToString();
                    client.companyClient = custReader["company"].ToString();
                    client.phoneClient = custReader["phone"].ToString();
                    client.paymentClient = custReader["payment"].ToString();
                    client.emailClient = custReader["email"].ToString();
                    client.updatedClient = Convert.ToDateTime(custReader["updated"]);
                    client.createdClient = Convert.ToDateTime(custReader["created"]);
                    clients.Add(client);
                }
                custReader.Close();
                return clients;
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
    

