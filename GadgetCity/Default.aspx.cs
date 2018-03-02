using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace GadgetCity
{
    public partial class _Default : Page
    {
        static SqlConnection cgCOnn = new SqlConnection(ConfigurationManager.ConnectionStrings["cgConnection"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            showBrand();
        }


        public void showBrand()
        {
            try
            {
                cgCOnn.Open();
                SqlCommand get_BrandData = new SqlCommand("SELECT * FROM brand",cgCOnn);
                SqlDataReader cg_brand = get_BrandData.ExecuteReader();
                  while (cg_brand.Read())
                    {
                        viewBrandDiv.InnerHtml += "<div class='col-md-2 item'>";
                        viewBrandDiv.InnerHtml += "<a href = 'gcBranItems.aspx?vehicalBrand="+ cg_brand["brandId"].ToString() + "&BrandUrl="+ cg_brand["imgUrl"].ToString() + "&Brand="+ cg_brand["brandName"].ToString() + "'>";
                        viewBrandDiv.InnerHtml += "<img src='" + cg_brand["imgUrl"].ToString() + "' class='img-responsive car-logo' />";
                        viewBrandDiv.InnerHtml += "</a>";
                        viewBrandDiv.InnerHtml += "</div>";
                        
                    }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}