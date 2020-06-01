using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace off.universite
{
    public partial class universite_listesi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            DataSet1TableAdapters.universiteTableAdapter univ = new DataSet1TableAdapters.universiteTableAdapter();
            universiteList.DataSource = univ.UniversiteListesiGetir();
            //universiteList in data kaynagını benim databaseden cektigim verileri aktar
            // ve bunu ona bagla
            universiteList.DataBind(); //verileri aktarma işlemi liste sayfasına
        

        }

        
    }
}