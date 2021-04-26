using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace INVENTORY.Dataaccess_layer
{
    public class DataAccess
    {
        SqlConnection con;
        SqlCommand command;
        public DataAccess()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["Inventory"].ConnectionString);
            con.Open();
        }
        public SqlDataReader GetData(string sql)
        {
            command = new SqlCommand(sql, con);
            return command.ExecuteReader();
        }

        public int ExecuteQuery(string sql)
        {
            command = new SqlCommand(sql, con);
            return command.ExecuteNonQuery();
        }

        public void Dispose()
        {
            con.Close();
        }
    }
}
