using INVENTORY.Dataaccess_layer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INVENTORY.Business_layer.EntityDataAccess
{
   public class Productdataaccess
    {
        DataAccess da;

        public Productdataaccess()
        {
            da = new DataAccess();
        }


        public Products GetthatProduct(int id)
        {
            string sql = "SELECT * FROM Products where Id=" + id;
            SqlDataReader reader = da.GetData(sql);
            Products p = new Products();
            while (reader.Read())
            {
                p.Id = (int)reader["Id"];
                p.Name = reader["Name"].ToString();
                p.Cost = (int)reader["Cost"];
                p.Price = (int)reader["Price"];
                p.Quantity = (int)reader["Quantity"];
                p.Totalcost = (int)reader["Totalcost"];
                p.Totalprice = (int)reader["Totalprice"];
                p.Netprofit = (int)reader["Netprofit"];
                p.Threatcall = (int)reader["Threatcall"];
                p.Pic = reader["Pic "].ToString();
                p.Cid = (int)reader["Cid"];

            }
            return p;

        }
        public List<Products> GetAllProducts()
        {
            string sql = "SELECT * FROM Products";
            SqlDataReader reader = da.GetData(sql);
            List<Products> list = new List<Products>();
            while (reader.Read())
            {
                Products p = new Products();
                p.Id = (int)reader["Id"];
                p.Name = reader["Name"].ToString();
                p.Cost = (int)reader["Cost"];
                p.Price = (int)reader["Price"];
                p.Quantity = (int)reader["Quantity"];
                p.Totalcost = (int)reader["Totalcost"];
                p.Totalprice = (int)reader["Totalprice"];
                p.Netprofit = (int)reader["Netprofit"];
                p.Threatcall = (int)reader["Threatcall"];
                p.Pic = reader["Pic "].ToString();
                p.Cid = (int)reader["Cid"];

                list.Add(p);
            }


            return list;
        }
        public int AddProduct(Products p)
        {
            string sql = "INSERT INTO Employees (Name,Cost,Price,Quantity,Totalcost,Totalprice,Netprofit,Pic,Cid) VALUES('" + p.Name + "'," + p.Cost + "," + p.Price + "," + p.Quantity + "," + p.Totalcost + "," + p.Totalprice + "," + p.Netprofit + ",'" + p.Pic + "'," + p.Cid + ")";
            return da.ExecuteQuery(sql);
        }
        public int UpdateProduct(Products p, int id)
        {
            string sql = "UPDATE Products SET Name='" + p.Name + "',Cost=" + p.Cost + ",Price=" + p.Price + ",Quantity=" + p.Quantity + ",Totalcost=" + p.Totalcost + ",Totalprice=" + p.Totalprice + ",Netprofit=" + p.Netprofit + ",Pic='" + p.Pic + "',Cid=" + p.Cid + " WHERE Id=" + id;
            return da.ExecuteQuery(sql);
        }
        public int DeleteProduct(int id)
        {
            string sql = "DELETE FROM Products where Id=" + id;
            return da.ExecuteQuery(sql);
        }
    }
}
