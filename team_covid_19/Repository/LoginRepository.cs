using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using team_covid_19.Entities;
using System.Data.SqlClient;

namespace team_covid_19.Repository

{
    class LoginRepository
    {
        DataAccess dataAccess;
        public LoginRepository()
        {
            dataAccess = new DataAccess();

        }
        public int Validation(User user)
        {
            dataAccess = new DataAccess();
            string sql = "SELECT * FROM Credentials WHERE Email='" + user.Email + "' AND Password='" + user.Password + "'";

            //DataTable sql = new DataTable();
            //sda.Fill(dtbl);
            
            SqlDataReader reader = dataAccess.GetData(sql);
            reader.Read();
            int userType = (int)reader["UserType"];
            if(userType == 1)
            {
                return 1;
            }
            if(userType == 2)
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }

    }
}
