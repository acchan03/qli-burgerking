using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace DXApplication1
{
    internal class Ketnoi
    {
        private string con;
        public string myConnection()
        {
            con = @"Data Source=DESKTOP-F1KUP77;Initial Catalog=burgerKing;Integrated Security=True";
            return con;
        }
        
        public DataSet laydulieu(string query)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(ds);
                return ds;
            }
            catch { return null; }
        }

        public static string user;
        public static string USER
        {
            get { return user; }
            private set { user = value; }
        }

        
    }
}
