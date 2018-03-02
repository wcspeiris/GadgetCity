using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GadgetCity
{
    public partial class partOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string imageUrl = Request.QueryString["ImageUrl"];
            string GetpartName = Request.QueryString["PartName"];
            Partpicture.ImageUrl = imageUrl;
            partName.Text = GetpartName;
            runFUn();
        }

        public void runFUn()
        {
            gcbusiness.gcSpare.get_partInfo(Request.QueryString["partID"].ToString(),spareCateory,SpareBrand,sparePrice,ManuYear, SpareDescri);
        }
    }
}