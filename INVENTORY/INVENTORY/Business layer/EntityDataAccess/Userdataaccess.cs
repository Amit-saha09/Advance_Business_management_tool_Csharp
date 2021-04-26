using INVENTORY.Dataaccess_layer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INVENTORY.Business_layer.EntityDataAccess
{
   public class Userdataaccess
    {
        DataAccess da;

        public Userdataaccess()
        {
            da = new DataAccess();
        }


        public Users GetthatUser(string id)
        {
            string sql = "SELECT * FROM Users where Name='"+id+"'";
            SqlDataReader reader = da.GetData(sql);
            Users p = new Users();
            while (reader.Read())
            {
                p.Userid = (int)reader["Userid"];
                p.Name = reader["Name"].ToString();
                p.Password = reader["Passward"].ToString();
                p.Type = reader["Type"].ToString();
                p.Email = reader["Email"].ToString();
               p.Pic = reader["Pic"].ToString();
                p.Address = reader["Address"].ToString();
               p.Description = reader["Description"].ToString();
                p.Modifydate = reader["Modifydate"].ToString();

            }
            return p;

        }
        public List<Users> GetAllUsers()
        {
            string sql = "SELECT * FROM Users";
            SqlDataReader reader = da.GetData(sql);
            List<Users> list = new List<Users>();
            while (reader.Read())
            {
                Users p = new Users();
                p.Userid = (int)reader["Userid"];
                p.Name = reader["Name"].ToString();
                p.Password = reader["Passward"].ToString();
                p.Type = reader["Type"].ToString();
                p.Email = reader["Email"].ToString();
                p.Pic = reader["Pic"].ToString();
                p.Address = reader["Address"].ToString();
                p.Description = reader["Description"].ToString();
                p.Modifydate = reader["Modifydate"].ToString();

                list.Add(p);
            }


            return list;
        }
        public int AddUser(Users p)
        {
            string sql = "INSERT INTO Users (Name,Passward,Type,Email,Pic,Address,Description,Modifydate) VALUES('" + p.Name + "','" + p.Password + "','" + p.Type + "','" + p.Email + "','" + p.Pic + "','" + p.Address + "','" + p.Description + "','" + p.Modifydate + "')";
            return da.ExecuteQuery(sql);
        }
        public int UpdateUser(Users p, int id)
        {
            string sql = "UPDATE Users SET Name='" + p.Name + "',Password='" + p.Password + "',Type='" + p.Type + "',Email='" + p.Email + "',Pic='" + p.Pic + "',Address='" + p.Address + "',Description='" + p.Description + "',Modifydate='" + p.Modifydate + "' WHERE Id=" + id;
            return da.ExecuteQuery(sql);
        }
        public int DeleteUser(int id)
        {
            string sql = "DELETE FROM Users where Id=" + id;
            return da.ExecuteQuery(sql);
        }
    }
}
