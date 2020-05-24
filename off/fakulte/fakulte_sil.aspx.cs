using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace off.fakulte
{
    public partial class fakulte_sil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]); //id aldik

            DataSet1TableAdapters.fakulteTableAdapter fakulte = new DataSet1TableAdapters.fakulteTableAdapter();
            fakulte.FakulteSil(id);
            Response.Redirect("/fakulte/fakulte_listesi.aspx");

        }
    }
}