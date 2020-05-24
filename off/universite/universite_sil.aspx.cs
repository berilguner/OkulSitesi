using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace off.universite
{
    public partial class universite_sil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //sayfa yuklenir yuklenmez silme islemini yapicaz
            //id cekiyoruz
            int id = Convert.ToInt32(Request.QueryString["id"]);

            DataSet1TableAdapters.universiteTableAdapter univ = new DataSet1TableAdapters.universiteTableAdapter();
            univ.UniversiteSil(id);
            Response.Redirect("/universite/universite_listesi.aspx"); //sayfa yonlendirme
        }
    }
}