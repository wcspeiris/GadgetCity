using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GadgetCity
{
    public partial class sendReplay : System.Web.UI.Page
    {
        string email;
        string message;
        string clientName;
        string inqId;
        string dateTime;
        ReceptionistWebForms.ReceptionistClasses.sendInquiryReplay inquRep = new ReceptionistWebForms.ReceptionistClasses.sendInquiryReplay();
        protected void Page_Load(object sender, EventArgs e)
        {
            inqId = Request.QueryString["inqId"].ToString();
            clientName = Request.QueryString["inqUN"].ToString();
            message = Request.QueryString["inqMessag"].ToString();
            email = Request.QueryString["inqEmail"].ToString();
            dateTime = Request.QueryString["inqdatt"];

            string letterOne = clientName.Substring(0, 1);
            InqNameShort.InnerText = letterOne;

            InqName.InnerText = clientName;
            InqMessage.InnerText = message;
            InqEmail.InnerText = "TO: "+email;
            InqDate.InnerText = dateTime;
        }

        protected void sendEmail_Click(object sender, EventArgs e)
        {
            if(RepMessage.Text == "")
            {
                RepMessage.CssClass = " alert_replybox";
            }
            else
            {
                bool resu = inquRep.sendReplay(email, clientName, RepMessage.Text, inqId);
                if (resu == true)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "SweetAlert", "swal('Success!', 'Email Sent Successful !', 'success').then(function(){window.top.location.reload();})", true);

                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "SweetAlert", "swal('Success!', 'New Customer Registered', 'error').then(function(){})", true);
                }
            }
        }
    }
}