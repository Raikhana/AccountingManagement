/*
 * Author - Raikhana Urazbaeva 
 * Class - CompanyDB connection to database
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
    class CompanyDB_Class
    {
        public static SqlConnection GetConnection()
        {
            string connectionString =
                "Data Source=DESKTOP-***\\SQLEXPRESS;" +
                "Initial Catalog=***;" +
                "User id=***;" +
                "Password=***;";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
