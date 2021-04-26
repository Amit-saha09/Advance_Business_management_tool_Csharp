using INVENTORY.Dataaccess_layer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INVENTORY.Business_layer.EntityDataAccess
{
    public class Supplierdataaccess
    {
        DataAccess da;

        public Supplierdataaccess()
        {
            da = new DataAccess();
        }


        public Suppliers GetthatSupplier(int id)
        {
            string sql = "SELECT * FROM Suppliers where Id=" + id;
            SqlDataReader reader = da.GetData(sql);
            Suppliers p = new Suppliers();
            while (reader.Read())
            {
                p.Id = (int)reader["Id"];
                p.Name = reader["Name"].ToString();
                p.Country = reader["Country"].ToString();
                p.Address = reader["Address"].ToString();
                p.Pic = reader["Pic"].ToString();
                p.Email = reader["Email"].ToString();
                p.Phone = reader["Phone"].ToString();

            }
            return p;

        }
        public List<Suppliers> GetAllSuppilers()
        {
            string sql = "SELECT * FROM Suppliers";
            SqlDataReader reader = da.GetData(sql);
            List<Suppliers> list = new List<Suppliers>();
            while (reader.Read())
            {
                Suppliers p = new Suppliers();
                p.Id = (int)reader["Id"];
                p.Name = reader["Name"].ToString();
                p.Country = reader["Country"].ToString();
                p.Address = reader["Address"].ToString();
                p.Pic = reader["Pic "].ToString();
                p.Email = reader["Email"].ToString();
                p.Phone = reader["Phone"].ToString();

                list.Add(p);
            }


            return list;
        }
        public int AddSupplier(Suppliers p)
        {
            string sql = "INSERT INTO Suppliers (Name,Country,Address,Pic,Email,Phone) VALUES('" + p.Name + "','" + p.Country + "','" + p.Address + "','" + p.Pic + "','" + p.Email + "','" + p.Phone + "')";
            return da.ExecuteQuery(sql);
        }
        public int UpdateSupplier(Suppliers p, int id)
        {
            string sql = "UPDATE Suppliers SET Name='" + p.Name + "',Country='" + p.Country + "',Address='" + p.Address + "',Pic='" + p.Pic + "',Email='" + p.Email + "',Phone='" + p.Phone + "' WHERE Id=" + id;
            return da.ExecuteQuery(sql);
        }
        public int DeleteSupplier(int id)
        {
            string sql = "DELETE FROM Suppliers where Id=" + id;
            return da.ExecuteQuery(sql);
        }
    }
}
