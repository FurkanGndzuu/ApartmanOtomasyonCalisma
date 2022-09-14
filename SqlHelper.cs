using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmanOtomasyonCalisma
{
    internal class SqlHelper
    {
        private string ConnectionString { get; set; }
        public SqlConnection Connection { get; set; }

        public SqlHelper()
        {
            Connection = new SqlConnection(ConnectionString);
            ConnectionString = "Data Source=DESKTOP-LDMU7VJ\\SQLEXPRESS; Initial Catalog=ApartmanGelirGider; Integrated Security=True";


        }

        public void executeProc(string procName,params SqlParameter[] ps)
        {
            SqlCommand command = new SqlCommand();  
            command.CommandType=CommandType.StoredProcedure;
            command.CommandText= procName;  
            command.Parameters.AddRange(ps);
            command.Connection = Connection;
            Connection.Open();
            command.ExecuteNonQuery();
            Connection.Close();
        }

        public DataTable getTable(string querry)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(querry,ConnectionString);
            DataTable table = new DataTable();  
            adapter.Fill(table);
            return table;

        }
    }
}
