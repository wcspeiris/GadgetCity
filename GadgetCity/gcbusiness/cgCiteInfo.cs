using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GadgetCity.gcbusiness
{
    public class SiteData
    {
            public  string SiteName { get; set; }
            public  string SiteEmail { get; set; }
            public  string SitePassword { get; set; }
    }

    public class cgCiteInfo
    {
        static SqlConnection cgCOnn = new SqlConnection(ConfigurationManager.ConnectionStrings["cgConnection"].ConnectionString);
        static SiteData sd = new SiteData();
        public void getSiteInfo()
        {
            try
            {
                cgCOnn.Open();
                SqlCommand get_SiteData = new SqlCommand("SELECT * FROM CompanyWeb", cgCOnn);
                SqlDataReader cg_site = get_SiteData.ExecuteReader();
                if (cg_site.Read())
                {
                    sd.SiteName = "gg1";
                }
                cgCOnn.Close();
            }

            catch(Exception ex)
            {
                
            }
            
        }
    }
}