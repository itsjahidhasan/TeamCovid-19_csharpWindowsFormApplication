using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace team_covid_19.Repository
{
    public class DataAccess : IDisposable
    {
        private SqlConnection connection;
        private SqlCommand command;
        public DataAccess()
        {
            this.connection = new SqlConnection(@"Data Source=DESKTOP-5UJRPCM;Initial Catalog=team19;Integrated Security=True;");
           
            this.connection.Open();
        }

        public SqlDataReader GetData(string sql)
        {
            this.command = new SqlCommand(sql, this.connection);
            return this.command.ExecuteReader();
        }

        public int ExecuteQuery(string sql)
        {
            this.command = new SqlCommand(sql, this.connection);
            return this.command.ExecuteNonQuery();
        }

        public void Dispose()
        {
            this.connection.Close();
        }
    }
}
