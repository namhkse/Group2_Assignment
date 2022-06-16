using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.IO;

namespace SE1617_Win.DAL
{
    public class DAO
    {
        string strConn;
        public DAO()
        {
            var conf = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();

            strConn = conf.GetConnectionString("DbConnection");
        }

        public DataTable GetDataTable(string sql)
        {

            //create object connection
            SqlConnection conn = new SqlConnection(strConn);

            //create object command
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = conn;

            //create DataAdapter
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //Insert, Update, delete depend cmd
        public void Update(SqlCommand cmd)
        {
            SqlConnection conn = new SqlConnection(strConn);
            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
