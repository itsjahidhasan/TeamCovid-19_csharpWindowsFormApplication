using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using team_covid_19.Entities;

namespace team_covid_19.Repository
{
    class SignupRepository
    {
        DataAccess dataAccess;
        public SignupRepository()
        {
            dataAccess = new DataAccess();
        }
        public int Signup(User user)
        {
            dataAccess = new DataAccess();
            string sql = "INSERT INTO Users(FirstName,LastName,DOB,Gender,PhoneNo,Address,Email) VALUES('" + user.FirstName + "','" + user.LastName + "','" + user.DOB + "','" + user.Gender + "','" + user.PhoneNo + "','" + user.Address + "','" + user.Email + "')";
            int result = dataAccess.ExecuteQuery(sql);
            if(result>0)
            {
                dataAccess = new DataAccess();
                sql = "SELECT * FROM Users WHERE Email='" + user.Email + "'";
             
                SqlDataReader reader = dataAccess.GetData(sql);
                reader.Read();
                int id = (int)reader["UserId"];


                dataAccess = new DataAccess();
                sql = "INSERT INTO Credentials(Email,Password,UserType,UserId) VALUES('" + user.Email + "','" + user.Password + "'," + user.UserType + "," + id + ")";
                result = dataAccess.ExecuteQuery(sql);
                if(result>0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }

            }
            else { return 0; }
        }
    }
}
