using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
namespace GadgetCity.gcdatabase
{
    public class gcConnection
    {
        public static SqlConnection gnConn = null;

        public void gcOpenConn()
        {
            gnConn = new SqlConnection (@"Data Source=BURNS-HAND\SQLEXPRESS;Initial Catalog=GadgetCity;Integrated Security=True");
            gnConn.Open();
        }

        public void gcCloseConn()
        {
            gnConn.Close();
        }
    }
}