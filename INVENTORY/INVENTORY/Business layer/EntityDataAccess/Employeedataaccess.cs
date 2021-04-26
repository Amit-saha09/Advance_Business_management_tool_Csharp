using INVENTORY.Dataaccess_layer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INVENTORY.Business_layer.EntityDataAccess
{
    public class Employeedataaccess
    {
        DataAccess da;

        public Employeedataaccess()
        {
            da = new DataAccess();
        }


        public Employees GetthatEmployee(int id)
        {
            string sql = "SELECT * FROM Employees where Id=" + id;
            SqlDataReader reader = da.GetData(sql);
            Employees p = new Employees();
            while (reader.Read())
            {
                p.Id = (int)reader["Id"];
                p.Name = reader["Name"].ToString();
                p.Address = reader["Address"].ToString();
                p.Phone = reader["Phone"].ToString();
                p.Email = reader["Email"].ToString();
                p.Hiredate = reader["Hiredate"].ToString();
                p.Salary = (int)reader["Salary"];
                p.Pic = reader["Pic "].ToString();
                p.Uid = (int)reader["Uid"];

            }
            return p;

        }
        public List<Employees> GetAllEmployees()
        {
            string sql = "SELECT * FROM Employees";
            SqlDataReader reader = da.GetData(sql);
            List<Employees> list = new List<Employees>();
            while (reader.Read())
            {
                Employees p = new Employees();
                p.Id = (int)reader["Id"];
                p.Name = reader["Name"].ToString();
                p.Address = reader["Address"].ToString();
                p.Phone = reader["Phone"].ToString();
                p.Email = reader["Email"].ToString();
                p.Hiredate = reader["Hiredate"].ToString();
                p.Salary = (int)reader["Salary"];
                p.Pic = reader["Pic "].ToString();
                p.Uid = (int)reader["Uid"];

                list.Add(p);
            }


            return list;
        }
        public int AddEmployee(Employees p)
        {
            string sql = "INSERT INTO Employees (Name,Address,Phone,Email,Hiredate,Salary,Pic,Uid) VALUES('" + p.Name + "','" + p.Address + "','" + p.Phone + "','" + p.Email + "','" + p.Hiredate + "'," + p.Salary + ",'" + p.Pic + "'," + p.Uid + ")";
            return da.ExecuteQuery(sql);
        }
        public int UpdateEmployee(Employees p, int id)
        {
            string sql = "UPDATE Employees SET Name='" + p.Name + "',Address='" + p.Address + "',Phone='" + p.Phone + "',Email='" + p.Email + "',Hiredate='" + p.Hiredate + "',Salary=" + p.Salary + ",Pic=" + p.Pic + "',Uid=" + p.Uid + " WHERE Id=" + id;
            return da.ExecuteQuery(sql);
        }
        public int DeleteEmployee(int id)
        {
            string sql = "DELETE FROM Employees where Id=" + id;
            return da.ExecuteQuery(sql);
        }
    }
}
