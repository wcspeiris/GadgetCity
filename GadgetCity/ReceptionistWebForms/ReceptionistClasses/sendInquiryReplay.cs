using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI.WebControls;

namespace GadgetCity.ReceptionistWebForms.ReceptionistClasses
{
    public class sendInquiryReplay
    {
        static SqlConnection cgCOnn = new SqlConnection(ConfigurationManager.ConnectionStrings["cgConnection"].ConnectionString);
        public static void inqCOunter(Label inqCOunt)
        {
            cgCOnn.Open();
            SqlCommand CountInq = new SqlCommand("SELECT COUNT(*) as inqCOunt FROM gcInquery WHERE inquery_status = '1'", cgCOnn);
            SqlDataReader inqCount = CountInq.ExecuteReader();
            while (inqCount.Read())
            {
                inqCOunt.Text = inqCount["inqCOunt"].ToString();
            }
            
            cgCOnn.Close();
        }
        public Boolean sendReplay(string clientEmail,string clientName,string replayMessage,string inqId)
        {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("gadgetcity2018@gmail.com", "hnd2@123");
                MailMessage stuml = new MailMessage();
                stuml.To.Add(clientEmail);
                stuml.From = new MailAddress("gadgetcity2018@gmail.com");
                stuml.Subject = ("Inquiry Reply");
                stuml.Body = ("Hello " + clientName + ". \n" + replayMessage.ToString());
                client.Send(stuml);
                stuml.IsBodyHtml = true;
                cgCOnn.Open();
                SqlCommand updInq = new SqlCommand("UPDATE gcInquery SET inquery_status = '0' WHERE Inquery_id ='"+ inqId + "'",cgCOnn);
                int Result = updInq.ExecuteNonQuery();
                cgCOnn.Close();
                if (Result == 1)
                    {
                        return true;
                    }
                        else
                    {
                        return false;
                    }
            
        }
    }
}