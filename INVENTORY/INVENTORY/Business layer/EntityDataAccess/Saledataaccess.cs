using INVENTORY.Dataaccess_layer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INVENTORY.Business_layer.EntityDataAccess
{
   public class Saledataaccess
    {
        DataAccess da;

        public Saledataaccess()
        {
            da = new DataAccess();
        }


        public Sales GetthatSale(int id)
        {
            string sql = "SELECT * FROM Sales where Id=" + id;
            SqlDataReader reader = da.GetData(sql);
            Sales p = new Sales();
            while (reader.Read())
            {
                p.Id = (int)reader["Id"];
                p.Description = reader["Description"].ToString();
                p.Totalcost = (int)reader["Totalcost"];
                p.Uid = (int)reader["Uid"];
                p.Empid = (int)reader["Empid"];
                p.Cusid = (int)reader["Cusid"];


            }
            return p;

        }
        public List<Sales> GetAllSales()
        {
            string sql = "SELECT * FROM Sales";
            SqlDataReader reader = da.GetData(sql);
            List<Sales> list = new List<Sales>();
            while (reader.Read())
            {
                Sales p = new Sales();
                p.Id = (int)reader["Id"];
                p.Description = reader["Description"].ToString();
                p.Totalcost = (int)reader["Totalcost"];
                p.Uid = (int)reader["Uid"];
                p.Empid = (int)reader["Empid"];
                p.Cusid = (int)reader["Cusid"];
                list.Add(p);
            }


            return list;
        }
        public int AddSale(Sales p)
        {
            string sql = "INSERT INTO Employees (Description,Totalcost,Uid,Empid,Cusid) VALUES('" + p.Description + "'," + p.Totalcost + "," + p.Uid + "," + p.Empid + "," + p.Cusid + ")";
            return da.ExecuteQuery(sql);
        }
        public int UpdateSale(Sales p, int id)
        {
            string sql = "UPDATE Sales SET Description='" + p.Description + "',Totalcost=" + p.Totalcost + ",Uid=" + p.Uid + ",Empid=" + p.Empid + ",Cusid=" + p.Cusid + " WHERE Id=" + id;
            return da.ExecuteQuery(sql);
        }
        public int DeleteSale(int id)
        {
            string sql = "DELETE FROM Sales where Id=" + id;
            return da.ExecuteQuery(sql);
        }
    }
}
