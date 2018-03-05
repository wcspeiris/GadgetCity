using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GadgetCity.inquireView
{
    public partial class InquiryList : System.Web.UI.Page
    {
        static SqlConnection cgCOnn = new SqlConnection(ConfigurationManager.ConnectionStrings["cgConnection"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            viewInquiryList();
        }

        public void viewInquiryList()
        {
            cgCOnn.Open();
            SqlCommand get_InqueryData = new SqlCommand("SELECT * FROM gcInquery", cgCOnn);
            SqlDataReader cg_inquiry = get_InqueryData.ExecuteReader();
            while (cg_inquiry.Read())
            {
                
                inqueryView.InnerHtml += "<p class='inqueryName'>"+ cg_inquiry["Inquery_userName"].ToString() + "</p>";
                inqueryView.InnerHtml += "<p class='inqueryMessage'>" + cg_inquiry["inquery_message"].ToString() + "</p>";
                inqueryView.InnerHtml += "<a target='Namegg' class='butto_url_replay' href='sendReplay.aspx?inqId=" + cg_inquiry["Inquery_id"].ToString() + "&inqUN="+ cg_inquiry["Inquery_userName"].ToString() + "&inqEmail="+ cg_inquiry["Inquery_email"].ToString() + "&inqMessag=" + cg_inquiry["inquery_message"].ToString() + "&inqdatt=" + cg_inquiry["inquery_date"].ToString() + "'>Replay</a>";
                inqueryView.InnerHtml += "<hr />";
            }
            cgCOnn.Close();
        }

        public void Ref()
        {
            Response.Write("<script>alert('Hello');</script>");
        }
    }
}