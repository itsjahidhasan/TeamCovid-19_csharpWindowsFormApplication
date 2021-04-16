using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using team_covid_19.Interfaces;
using team_covid_19.Entities;
//using team_covid_19.UI;

namespace team_covid_19.Repository
{
    public class UserRepository:IRepository<User>
    {

        DataAccess dataAccess;
        public UserRepository()
        {
            this.dataAccess = new DataAccess();
        }
        public List<User> GetAll()
        {
            dataAccess = new DataAccess();
            string sql = "SELECT * FROM Users";
            SqlDataReader reader = dataAccess.GetData(sql);
            List<User> userList = new List<User>();
            while (reader.Read())
            {
                User user = new User();
          
                user.UserId = Convert.ToInt32(reader["UserId"]);
                user.FirstName = reader["FirstName"].ToString();
                user.LastName = reader["LastName"].ToString();
                
                user.DOB = reader["DOB"].ToString();
                user.Gender = reader["Gender"].ToString();
                
                user.PhoneNo = reader["PhoneNo"].ToString();
                user.Address = reader["Address"].ToString();
                user.Email = reader["Email"].ToString();

                //user.UserType = Convert.ToInt32(reader["UserType"]);
                userList.Add(user);
                
            }
            dataAccess.Dispose();
            return userList;
        }

        public User Get(int id)
        {
            dataAccess = new DataAccess();
            string sql = "SELECT * FROM Users WHERE UserId="+id;
            SqlDataReader reader = dataAccess.GetData(sql);
            reader.Read();
             User user = new User();
                user.UserId = Convert.ToInt32(reader["UserId"]);
                user.FirstName = reader["FirstName"].ToString();
                user.LastName = reader["LastName"].ToString();
                
                user.DOB = reader["DOB"].ToString();
                user.Gender = reader["Gender"].ToString();
                ;
                user.PhoneNo = reader["PhoneNo"].ToString();
                user.Address = reader["Address"].ToString();
                user.Email = reader["Email"].ToString();
            dataAccess.Dispose();
            return user;
        }
        public int Insert(User entity)
        {
            dataAccess = new DataAccess();
            string sql = "INSERT INTO Users(UserId,FirstName,LastName,DOB,Gender,PhoneNo,Address,Email,UserType) VALUES('" + entity.UserId + "'," + entity.FirstName + "," + entity.LastName + "," + entity.DOB+"," + entity.Gender +"," + entity.PhoneNo +"," + entity.Address +"," + entity.Email +"," +entity.UserType+")";
            int result = dataAccess.ExecuteQuery(sql);
            dataAccess.Dispose();
            return result;
        }
        public int Update(User entity )
        {
            dataAccess = new DataAccess();
            string sql = "UPDATE Users SET FirstName='" + entity.FirstName + "',LastName=" + entity.LastName + ",DOB=" + entity.DOB + ",PhoneNo=" + entity.PhoneNo + "  WHERE UserId=" + entity.UserId ;
            int result = dataAccess.ExecuteQuery(sql);
            dataAccess.Dispose();
            return result;
        }
        public int Delete(int id)
        {
            dataAccess = new DataAccess();
            string sql = "DELETE FROM Users WHERE UserId=" + id;
            int result = dataAccess.ExecuteQuery(sql);
            dataAccess.Dispose();
            return result;
        }
    }
}
