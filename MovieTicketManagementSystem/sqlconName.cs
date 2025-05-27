using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;


namespace MovieTicketManagementSystem
{
     class sqlconName
    {
        public SqlConnection connection()
        {
            SqlConnection connection = new SqlConnection("Data Source=LAPTOP-PM5A38PG\\SQLEXPRESS;Initial Catalog=movie;Integrated Security=True;");
            connection.Open();
            return connection;
    }
      

    }
}
