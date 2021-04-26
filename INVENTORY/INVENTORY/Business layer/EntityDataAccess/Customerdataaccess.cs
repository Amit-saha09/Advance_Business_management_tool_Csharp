using INVENTORY.Dataaccess_layer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INVENTORY.Business_layer.EntityDataAccess
{
    public class Customerdataaccess
    {
        DataAccess da;

        public Customerdataaccess()
        {
            da = new DataAccess();
        }


        public Customers GetthatCustomer(int id)
        {
            string sql = "SELECT * FROM Customers where Id=" + id;
            SqlDataReader reader = da.GetData(sql);
            Customers p = new Customers();
            while (reader.Read())
            {
                p.Id = (int)reader["Id"];
                p.Name = reader["Name"].ToString();
                p.Email = reader["Email"].ToString();
                p.Phone = reader["Phone"].ToString();
                p.Address = reader["Address"].ToString();
                p.Entrydate = reader["Entrydate"].ToString();
                p.Pic = reader["Pic "].ToString();
                p.Uid = (int)reader["Uid"];

            }
            return p;

        }
        public List<Customers> GetAllCustomers()
        {
            string sql = "SELECT * FROM Customers";
            SqlDataReader reader = da.GetData(sql);
            List<Customers> list = new List<Customers>();
            while (reader.Read())
            {
                Customers p = new Customers();
                p.Id = (int)reader["Id"];
                p.Name = reader["Name"].ToString();
                p.Email = reader["Email"].ToString();
                p.Phone = reader["Phone"].ToString();
                p.Address = reader["Address"].ToString();
                p.Entrydate = reader["Entrydate"].ToString();
                p.Pic = reader["Pic "].ToString();
                p.Uid = (int)reader["Uid"];

                list.Add(p);
            }


            return list;
        }
        public int AddCustomer(Customers p)
        {
            string sql = "INSERT INTO Suppliers (Name,Email,Phone,Address,Entrydate,Pic,Uid) VALUES('" + p.Name + "','" + p.Email + "','" + p.Phone + "','" + p.Address + "','" + p.Entrydate + "','" + p.Pic + "'," + p.Uid + ")";
            return da.ExecuteQuery(sql);
        }
        public int UpdateCustomer(Customers p, int id)
        {
            string sql = "UPDATE Customers SET Name='" + p.Name + "',Email='" + p.Email + "',Phone='" + p.Phone + "',Address='" + p.Address + "',Entrydate='" + p.Entrydate + "',Pic=" + p.Pic + "',Uid=" + p.Uid + " WHERE Id=" + id;
            return da.ExecuteQuery(sql);
        }
        public int DeleteCustomer(int id)
        {
            string sql = "DELETE FROM Customers where Id=" + id;
            return da.ExecuteQuery(sql);
        }
    }
}
