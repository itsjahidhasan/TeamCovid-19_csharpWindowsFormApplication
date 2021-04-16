using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using team_covid_19.Entities;

namespace team_covid_19.Repository
{
    class AdminLoginRepository
    {
        DataAccess dataAccess;
        public AdminLoginRepository()
        {
            dataAccess = new DataAccess();

        }
        public int Validation(Admin admin)
        {
            dataAccess = new DataAccess();
            string sql = "SELECT * FROM Admins WHERE Email='" + admin.Email + "' AND Password='" + admin.Password + "'";
            SqlDataReader reader = dataAccess.GetData(sql);
            reader.Read();
            
            if(reader.Read())
            {
                return 1;
            }
            else { return 0; }
        }
    }
}
