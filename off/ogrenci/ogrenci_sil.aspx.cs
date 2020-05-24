using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace off.ogrenci
{
    public partial class ogrenci_sil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(Request.QueryString["id"]);

            DataSet1TableAdapters.ogrenciTableAdapter ogrenci = new DataSet1TableAdapters.ogrenciTableAdapter();
            ogrenci.OgrenciSil(id);
            Response.Redirect("/ogrenci/ogrenci_listesi.aspx");

        }
    }
}