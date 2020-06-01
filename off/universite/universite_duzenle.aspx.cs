using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace off.universite
{
    public partial class universite_duzenle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Convert.ToInt32(Request.QueryString["id"].ToString());

                DataSet1TableAdapters.universiteTableAdapter univ = new DataSet1TableAdapters.universiteTableAdapter();

                string universiteAdi = univ.UniversiteGetir(id)[0].universite_adi;
                txtUniversiteAdi.Text = universiteAdi;

            }

        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"].ToString());

            DataSet1TableAdapters.universiteTableAdapter univ = new DataSet1TableAdapters.universiteTableAdapter();
            univ.UniversiteGuncelle(txtUniversiteAdi.Text, id);
            Response.Redirect("/universite/universite_listesi.aspx");  //listeleme sayfasına yonlendirdik kaydet butonuna basıldıgı anda


        }

       
    }
}