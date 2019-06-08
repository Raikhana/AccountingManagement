/*
 * Author - Raikhana Urazbaeva 
 * Class - Users DB Queries for a user table
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
   public static class UsersDB_Class
    {
        public static List<UsersClass> GetUsers()
        {
            SqlConnection connection = CompanyDB_Class.GetConnection();
            string selectStatement
                = "SELECT id, first_name, last_name, email, phone, " +
                  "password, role, approved, created, updated "
                + "FROM users";
            SqlCommand selectcommand =
                new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader custReader =
                    selectcommand.ExecuteReader();

                List<UsersClass> users = new List<UsersClass>();
                while (custReader.Read())
                {
                    UsersClass user = new UsersClass();
                    user.userID = (int)custReader["id"];
                    user.firstNameUsers = custReader["first_name"].ToString();
                    user.lastNameUsers = custReader["last_name"].ToString();
                    user.emailUsers = custReader["email"].ToString();
                    user.phoneUsers = custReader["phone"].ToString();
                    user.roleUsers = custReader["role"].ToString();
                    user.createdUsers = Convert.ToDateTime(custReader["created"]);
                    user.updatedUsers = Convert.ToDateTime(custReader["updated"]);
                    user.approvedUsers = custReader["approved"].ToString();
                    user.passwordUsers = custReader["password"].ToString();
                    users.Add(user);
                }
                custReader.Close();
                 return users;

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

        public static UsersClass GetAdmin(string adminEmail)
        {
            SqlConnection connection = CompanyDB_Class.GetConnection();
            string selectStatement
                = "SELECT id, first_name, last_name, email, phone, " +
                  "password, role, approved, created, updated "
                + "FROM users "
                + "WHERE email = @adminEmail" +
                        " AND role = 'admin'";
                         
            SqlCommand selectcommand =
                new SqlCommand(selectStatement, connection);
            selectcommand.Parameters.AddWithValue("@adminEmail", adminEmail);
            try
            {
                connection.Open();
                SqlDataReader custReader =
                    selectcommand.ExecuteReader(CommandBehavior.SingleRow);
                if (custReader.Read())
                {
                    UsersClass user = new UsersClass();
                    user.userID = (int)custReader["id"];
                    user.firstNameUsers = custReader["first_name"].ToString();
                    user.lastNameUsers = custReader["last_name"].ToString();
                    user.emailUsers = custReader["email"].ToString();
                    user.phoneUsers = custReader["phone"].ToString();
                    user.roleUsers = custReader["role"].ToString();
                    user.createdUsers = Convert.ToDateTime(custReader["created"]);
                    user.updatedUsers = Convert.ToDateTime(custReader["updated"]);
                    user.approvedUsers = custReader["approved"].ToString();
                    user.passwordUsers = custReader["password"].ToString();
                    return user;
                }
                else
                {
                    return null;
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


        public static UsersClass GetUser(string userEmail)
        {
            SqlConnection connection = CompanyDB_Class.GetConnection();
            string selectStatement
                = "SELECT id, first_name, last_name, email, phone, " +
                  "password, role, approved, created, updated "
                + "FROM users "
                + "WHERE email = @userEmail" +
                  " AND role = 'user'" +
                  " AND approved = '1'"; 
            SqlCommand selectcommand =
                new SqlCommand(selectStatement, connection);
            selectcommand.Parameters.AddWithValue("@userEmail", userEmail);

            try
            {
                connection.Open();
                SqlDataReader custReader =
                    selectcommand.ExecuteReader(CommandBehavior.SingleRow);
                if (custReader.Read())
                {
                    UsersClass user = new UsersClass();
                    user.userID = (int)custReader["id"];
                    user.firstNameUsers = custReader["first_name"].ToString();
                    user.lastNameUsers = custReader["last_name"].ToString();
                    user.emailUsers = custReader["email"].ToString();
                    user.phoneUsers = custReader["phone"].ToString();
                    user.roleUsers = custReader["role"].ToString();
                    user.createdUsers = Convert.ToDateTime(custReader["created"]);
                    user.updatedUsers = Convert.ToDateTime(custReader["updated"]);
                    user.approvedUsers = custReader["approved"].ToString();
                    user.passwordUsers = custReader["password"].ToString();
                    return user;
                }
                else
                {
                    return null;
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

        public static UsersClass GetUserByID(string userID)
        {
            SqlConnection connection = CompanyDB_Class.GetConnection();
            string selectStatement
                = "SELECT id, first_name, last_name, email, phone, " +
                  "password, role, approved, created, updated "
                + "FROM users "
                + "WHERE id = @userID";
            SqlCommand selectcommand =
                new SqlCommand(selectStatement, connection);
            selectcommand.Parameters.AddWithValue("@userID", userID);

            try
            {
                connection.Open();
                SqlDataReader custReader =
                    selectcommand.ExecuteReader(CommandBehavior.SingleRow);
                if (custReader.Read())
                {
                    UsersClass user = new UsersClass();
                    user.userID = (int)custReader["id"];
                    user.firstNameUsers = custReader["first_name"].ToString();
                    user.lastNameUsers = custReader["last_name"].ToString();
                    user.emailUsers = custReader["email"].ToString();
                    user.phoneUsers = custReader["phone"].ToString();
                    user.roleUsers = custReader["role"].ToString();
                    user.createdUsers = Convert.ToDateTime(custReader["created"]);
                    user.updatedUsers = Convert.ToDateTime(custReader["updated"]);
                    user.approvedUsers = custReader["approved"].ToString();
                    user.passwordUsers = custReader["password"].ToString();
                    return user;
                }
                else
                {
                    return null;
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

        public static bool CreateAdmin(UsersClass user)
        {
            SqlConnection connection = CompanyDB_Class.GetConnection();
            string insertStatement =
                "INSERT INTO Users " +
                "( first_name, last_name, email, phone, " +
                  "password, role, approved, created, updated ) " +
                "VALUES ( @firstNameUsers, @lastNameUsers, @emailUsers, @phoneUsers, " +
                " @passwordUsers, @roleUsers, @approvedUsers, @createdUsers, @updatedUsers)";
            SqlCommand insertCommand =
                new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue(
               "@firstNameUsers", user.firstNameUsers);
            insertCommand.Parameters.AddWithValue(
                "@lastNameUsers", user.lastNameUsers);
            insertCommand.Parameters.AddWithValue(
                "@emailUsers", user.emailUsers);
            insertCommand.Parameters.AddWithValue(
                "@phoneUsers", user.phoneUsers);
            insertCommand.Parameters.AddWithValue(
                "@roleUsers", user.roleUsers);

            insertCommand.Parameters.AddWithValue(
                "@createdUsers", user.createdUsers);

            insertCommand.Parameters.AddWithValue(
                "@updatedUsers", user.updatedUsers);

            insertCommand.Parameters.AddWithValue(
                "@approvedUsers", user.approvedUsers);
            insertCommand.Parameters.AddWithValue(
                "@passwordUsers", user.passwordUsers);
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
        
        public static bool ApproveUsers(int id)
        {
            SqlConnection connection = CompanyDB_Class.GetConnection();
            string updateStatement =
                "UPDATE users SET approved = 1 WHERE id = @id";
            SqlCommand updateCommand =
                new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue("@id", id);
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
        
        public static bool DeleteUsers(int id)
        {
            SqlConnection connection = CompanyDB_Class.GetConnection();
            string deleteStatement =
                "DELETE FROM users " +
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
        public static bool ChangeUsers(UsersClass user)
        {
            SqlConnection connection = CompanyDB_Class.GetConnection();
            string updateStatement =
                "UPDATE users SET " +
                "first_name = @first_name, " +
                "last_name = @last_name, " +
                "email = @email, " +
                "phone = @phone, " +
                "role = @role, " +
                "updated = @updated, " +
                "password = @password " +
                " WHERE id = @id ";
            SqlCommand updateCommand =
                new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue(
                "@id", user.userID);
            updateCommand.Parameters.AddWithValue(
               "@first_name", user.firstNameUsers);
            updateCommand.Parameters.AddWithValue(
                "@last_name", user.lastNameUsers);
            updateCommand.Parameters.AddWithValue(
                "@email", user.emailUsers);
            updateCommand.Parameters.AddWithValue(
                "@phone", user.phoneUsers);
            updateCommand.Parameters.AddWithValue(
                "@role", user.roleUsers);
            updateCommand.Parameters.AddWithValue(
                "@updated", user.updatedUsers);
            updateCommand.Parameters.AddWithValue(
                "@password", user.passwordUsers);
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

        public static bool CreateProfile(UsersClass user)
        {
            SqlConnection connection = CompanyDB_Class.GetConnection();
            string insertStatement =
                "INSERT INTO Users " +
                "( first_name, last_name, email, phone, " +
                  "password, role, approved, created, updated ) " +
                "VALUES ( @firstNameUsers, @lastNameUsers, @emailUsers, @phoneUsers, " +
                " @passwordUsers, @roleUsers, @approvedUsers, @createdUsers, @updatedUsers)";
            SqlCommand insertCommand =
                new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue(
               "@firstNameUsers", user.firstNameUsers);
            insertCommand.Parameters.AddWithValue(
                "@lastNameUsers", user.lastNameUsers);
            insertCommand.Parameters.AddWithValue(
                "@emailUsers", user.emailUsers);
            insertCommand.Parameters.AddWithValue(
                "@phoneUsers", user.phoneUsers);
            insertCommand.Parameters.AddWithValue(
                "@roleUsers", user.roleUsers);

            insertCommand.Parameters.AddWithValue(
                "@createdUsers", user.createdUsers);

            insertCommand.Parameters.AddWithValue(
                "@updatedUsers", user.updatedUsers);

            insertCommand.Parameters.AddWithValue(
                "@approvedUsers", user.approvedUsers);
            insertCommand.Parameters.AddWithValue(
                "@passwordUsers", user.passwordUsers);
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

       

    }
}
