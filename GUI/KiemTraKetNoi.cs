using System.Data.SqlClient;
using System.Data;

namespace GUI
{
    public static class KiemTraKetNoi
    {
        static SqlConnection conn = new SqlConnection();
       public static string connstring = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=ninh_qlns;Integrated Security=True";
        static public void KetNoi()
        {
           
            conn.ConnectionString = connstring;
            try
            {
                conn.Open();
            }
            catch
            {

            }
        }
        static public DataTable getDatatable(string sql, string table)
        {
            if (conn.State == ConnectionState.Closed)
                KetNoi();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, table);
            return ds.Tables[table];
        }
    }
}
