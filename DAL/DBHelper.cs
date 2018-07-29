using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
namespace ITCastOCSS.DAL
{
    class DBHelper
    {
        private readonly  string constr = "data source=Lenovo-pc;initial catalog=ocss;integrated security=true";
        private static SqlConnection con;
        private static DBHelper mInstance;
        
       
        private DBHelper()
        {
            con= new SqlConnection(constr);
           
        } 
        public static DBHelper getInstance()
        {
            if (mInstance == null)
            {
                mInstance = new DBHelper();
            }
            return mInstance;
        }
        public int UpdateSql(String sql)
        {
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            int r = cmd.ExecuteNonQuery();
            return r;
        }
        public int RequrySql(String sql)
        {
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    //TblClass Tbl = new TblClass();
                    //Tbl.TclassId1 = reader.GetInt32(0);
                    //Tbl.TclassName1 = reader.GetString(1);
                    //Tbl.TclassDesc1 = reader.IsDBNull(2) ? null : reader.GetString(2);
                    //list.Add(Tbl);
                }
            }
            return 0;
        }
        public void CloseConnetcion()
        {
            if (con != null)
            {  
                con.Close();
            }
        }
    }
}
