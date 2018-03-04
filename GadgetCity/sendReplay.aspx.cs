﻿using System;
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
        protected void Page_Load(object sender, EventArgs e)
        {
            inqId = Request.QueryString["inqId"].ToString();
            clientName = Request.QueryString["inqUN"].ToString();
            message = Request.QueryString["inqMessag"].ToString();
            email = Request.QueryString["inqEmail"].ToString();
            dateTime = Request.QueryString["inqdatt"];

            string letterOne = clientName.Substring(0, 1);
            string secondWord = clientName.Split(' ')[1];
            string letterTwo = secondWord.Substring(0, 1);


            InqNameShort.InnerText = letterOne + letterTwo;
            InqName.InnerText = clientName;
            InqMessage.InnerText = message;
            InqEmail.InnerText = email;
            InqDate.InnerText = dateTime;
        }
    }
}