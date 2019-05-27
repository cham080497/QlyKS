using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QLKS_TTN
{
    class Connection
    {
        public static SqlConnection conn;
        public static SqlCommand cmd;
        public static SqlDataAdapter adapter;
        
        public SqlConnection OpenDB()
        {
            conn = new SqlConnection(@" Data Source = CHAMVU\CHAMVU; Initial Catalog = QLKS_TTN; Integrated Security = True");
            return conn;
        }
      
        public static void OpenConnection()
        {
            string sql = @" Data Source = CHAMVU\CHAMVU; Initial Catalog = QLKS_TTN; Integrated Security = True";
            try
            {
              
                conn = new SqlConnection(sql);
                conn.Open();
            }
            catch (SqlException ex)
            {

            }

        }
       
        public static void CloseConnection()
        {
            
            conn.Close();
            
            conn.Dispose();
            conn = null;
        }
        
        public static DataTable LayDuLieu(string sql)
        {
            
            cmd = new SqlCommand(sql, conn);
            
            adapter = new SqlDataAdapter();

            adapter.SelectCommand = cmd;
            
            DataTable table = new DataTable();
            
            adapter.Fill(table);
            adapter.Dispose();
            cmd.Dispose();
            return table;
        }
        
        public static void Excute(string sql)
        {
            cmd = new SqlCommand(sql, conn);
            
            cmd.ExecuteNonQuery();
        }
    }
}
