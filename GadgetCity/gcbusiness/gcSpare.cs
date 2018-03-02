using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace GadgetCity.gcbusiness
{
    public class gcSpare
    {
        static SqlConnection cgCOnn = new SqlConnection(ConfigurationManager.ConnectionStrings["cgConnection"].ConnectionString);

        public static void get_partInfo(String item_id, Label Catgory, Label Brand, Label Price, Label manuYeaar, Label Des)
        {
            cgCOnn.Open();
            SqlCommand get_ItemDate = new SqlCommand("SELECT * FROM spareParts WHERE sparePartId ="+ item_id + "", cgCOnn);
            SqlDataReader cg_itemDareExe = get_ItemDate.ExecuteReader();
            if (cg_itemDareExe.Read())
            {
                Brand.Text = cg_itemDareExe["sparePartBrand"].ToString();
                Catgory.Text = cg_itemDareExe["sparePartCategory"].ToString();
                Price.Text = cg_itemDareExe["sparePartPrice"].ToString();
                manuYeaar.Text = cg_itemDareExe["manufactureYear"].ToString();
                Des.Text = cg_itemDareExe["sparePartDescription"].ToString();
            }
            cgCOnn.Close();
        }
    }
}