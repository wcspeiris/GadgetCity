using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace GadgetCity.gcbusiness
{

    public class gcUserInquiry
    {
        static SqlConnection cgCOnn = new SqlConnection(ConfigurationManager.ConnectionStrings["cgConnection"].ConnectionString);

        public static Boolean sendInquiry(string inquiryUserName, string inquiryEmail, string inquiryMessage)
        {
            cgCOnn.Open();
            SqlCommand sendInquiry = new SqlCommand("INSERT INTO gcInquery(Inquery_userName,Inquery_email,inquery_message)VALUES('" + inquiryUserName + "','" + inquiryEmail + "','" + inquiryMessage + "')", cgCOnn);
                int Result = sendInquiry.ExecuteNonQuery();
                if (Result == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            cgCOnn.Close();
        }


    }

    }
