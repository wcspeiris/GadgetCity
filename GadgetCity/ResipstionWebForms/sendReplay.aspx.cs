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
        string secondWord;
        string letterTwo;
        protected void Page_Load(object sender, EventArgs e)
        {
            inqId = Request.QueryString["inqId"].ToString();
            clientName = Request.QueryString["inqUN"].ToString();
            message = Request.QueryString["inqMessag"].ToString();
            email = Request.QueryString["inqEmail"].ToString();
            dateTime = Request.QueryString["inqdatt"];

            string letterOne = clientName.Substring(0, 1);
            int spaceCount = clientName.TakeWhile(Char.IsWhiteSpace).Count();

            if(spaceCount == 1)
            {
                secondWord = clientName.Split(' ')[1];
                letterTwo = secondWord.Substring(0, 1);
                InqNameShort.InnerText = letterOne + letterTwo;
            }
            else
            {
                InqNameShort.InnerText = letterOne;
            }

            InqName.InnerText = clientName;
            InqMessage.InnerText = message;
            InqEmail.InnerText = email;
            InqDate.InnerText = dateTime;
        }
    }
}