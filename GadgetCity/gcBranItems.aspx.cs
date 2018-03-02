using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GadgetCity
{
    public partial class gcBranItems : System.Web.UI.Page
    {
        static SqlConnection cgCOnn = new SqlConnection(ConfigurationManager.ConnectionStrings["cgConnection"].ConnectionString);
        public string category, brandUrl, brandName;

        protected void Page_Load(object sender, EventArgs e)
        {
            category = Request.QueryString["vehicalBrand"];
            brandUrl = Request.QueryString["BrandUrl"];
            brandName = Request.QueryString["Brand"];

            headItile.InnerHtml = brandName.ToString() + " CAR PARTS";
            brandNameHead.InnerText = brandName.ToString();
            brandImage.ImageUrl = brandUrl.ToString();

            viewCarList(Request.QueryString["vehicalBrand"].ToString());
            viewCarPart(Request.QueryString["vehicalBrand"].ToString());

        }


        public void viewCarList(String VehicalID)
        {
            try
            {
                cgCOnn.Open();
                SqlCommand get_BrandData = new SqlCommand("SELECT * FROM vehical_list WHERE vehical_brand_id = '" + VehicalID + "'", cgCOnn);
                SqlDataReader cg_brand_model = get_BrandData.ExecuteReader();
                while (cg_brand_model.Read())
                {
                    carList.InnerHtml += "<input id=" + cg_brand_model["vehidal_id"].ToString() + " class='Item_cehckBox' type='checkbox' name='vehModel' value='" + cg_brand_model["vehidal_id"].ToString() + "'>";
                    carList.InnerHtml += "<p class='modeText'>" + cg_brand_model["vehical_name"].ToString() + "</p>";
                    carList.InnerHtml += "<hr>";
                }
                cgCOnn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void viewCarPart(String VehicalID)
        {
            try
            {
                cgCOnn.Open();
                SqlCommand get_BrandD_part_data = new SqlCommand("SELECT * FROM spareParts WHERE sparePartVehicalBrandID = '" + VehicalID + "'", cgCOnn);
                SqlDataReader cg_brand_model_parts = get_BrandD_part_data.ExecuteReader();
                while (cg_brand_model_parts.Read())
                {
                    PartList.InnerHtml += "<div class='col-md-4 text-center item_dive'>";
                    PartList.InnerHtml += "<img style='' src='" + cg_brand_model_parts["spartPartImageURl"].ToString() + "' class='img-responsive'/>";
                    PartList.InnerHtml += "<hr style = 'margin:5px' />";
                    PartList.InnerHtml += "<p style='font-size:15px;font-weight:bold;font-family:Calibri;margin:0px'>" + cg_brand_model_parts["sparePartName"].ToString() + "</p>";
                    PartList.InnerHtml += "<p style='font-size:25px;font-weight:bold;font-family:Calibri;color:#4da2fc;margin:0px'>RS " + cg_brand_model_parts["sparePartPrice"].ToString() + "</p>";
                    PartList.InnerHtml += "<a target='_blank' href='partOrder.aspx?partID=" + cg_brand_model_parts["sparePartId"].ToString() + "&ImageUrl="+ cg_brand_model_parts["spartPartImageURl"].ToString() + "&PartName="+ cg_brand_model_parts["sparePartName"].ToString() + "' class='butto_url'>Order</a>";
                    PartList.InnerHtml += "</div>";
                }
                cgCOnn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}