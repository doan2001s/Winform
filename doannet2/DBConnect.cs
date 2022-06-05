using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace doannet2
{
    class DBConnect
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-E02KF7HN;Initial Catalog=minimarket;Integrated Security=True");
        
        public SqlConnection GetCon()
        {
            return connection;
        }

        public void OpenCon()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseCon()
        {
            if(connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
