using INVENTORY.Dataaccess_layer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INVENTORY.Business_layer.EntityDataAccess
{
    public class Categorydataaccess
    {
        DataAccess da;

        public Categorydataaccess()
        {
            da = new DataAccess();
        }


        public Categories GetthatCategory(int id)
        {
            string sql = "SELECT * FROM Categories where Id=" + id;
            SqlDataReader reader = da.GetData(sql);
            Categories p = new Categories();
            while (reader.Read())
            {
                p.Id = (int)reader["Id"];
                p.Name = reader["Name"].ToString();
                p.Type = reader["Type"].ToString();
                p.Pic = reader["Pic"].ToString();
                p.Entrydate = reader["Entrydate"].ToString();
                p.Company = reader["Company"].ToString();
                p.Supid = (int)reader["Supid"];

            }
            return p;

        }
        public List<Categories> GetAllCategories()
        {
            string sql = "SELECT * FROM Categories";
            SqlDataReader reader = da.GetData(sql);
            List<Categories> list = new List<Categories>();
            while (reader.Read())
            {
                Categories p = new Categories();
                p.Id = (int)reader["Id"];
                p.Name = reader["Name"].ToString();
                p.Type = reader["Type"].ToString();
                p.Pic = reader["Pic"].ToString();
                p.Entrydate = reader["Entrydate "].ToString();
                p.Company = reader["Company"].ToString();
                p.Supid = (int)reader["Supid"];

                list.Add(p);
            }

            return list;
        }
        public int AddCategory(Categories p)
        {
            string sql = "INSERT INTO Categories (Name,Type,Pic,Entrydate,Company,Supid) VALUES('" + p.Name + "','" + p.Type + "','" + p.Pic + "','" + p.Entrydate + "','" + p.Company + "'," + p.Supid + ")";
            return da.ExecuteQuery(sql);
        }
        public int UpdateCategory(Categories p, int id)
        {
            string sql = "UPDATE Categories SET Name='" + p.Name + "',Type='" + p.Type + "',Pic='" + p.Pic + "',Entrydate='" + p.Entrydate + "',Company='" + p.Company + "',Supid=" + p.Supid + " WHERE Id=" + id;
            return da.ExecuteQuery(sql);
        }
        public int DeleteCategory(int id)
        {
            string sql = "DELETE FROM Categories where Id=" + id;
            return da.ExecuteQuery(sql);
        }
    }
}
