using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace off.fakulte
{
    public partial class fakulte_duzenle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // ilk olarak bu id ile fakulte veritabanına baglanıp fakulte adı ve uni id almam lazım

                DataSet1TableAdapters.fakulteTableAdapter fakulte = new DataSet1TableAdapters.fakulteTableAdapter();
                DataSet1TableAdapters.universiteTableAdapter univ = new DataSet1TableAdapters.universiteTableAdapter();

                int id = Convert.ToInt32(Request.QueryString["id"]);

         


                try
                {

                    int universiteID = fakulte.FakulteGetir(id)[0].universite_id;
                    string fakulteAdi = fakulte.FakulteGetir(id)[0].fakulte_adi;
                    string universiteAdi = univ.UniversiteGetir(universiteID)[0].universite_adi;

                    txtFakulteAdi.Text = fakulteAdi;

                    universiteCombo.Items.Clear();
                    universiteCombo.DataSource = univ.UniversiteListesiGetir();
                    universiteCombo.DataTextField = "universite_adi";
                    universiteCombo.DataValueField = "universite_id";
                    universiteCombo.DataBind();

                    //secili olan uni adını getirttik

                    universiteCombo.SelectedIndex = universiteCombo.Items.IndexOf(universiteCombo.Items.FindByText(universiteAdi));
                }
                catch
                {
                    
                }



            }

        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.fakulteTableAdapter fakulte = new DataSet1TableAdapters.fakulteTableAdapter();

            int id = Convert.ToInt32(Request.QueryString["id"]);
            int universiteID = Convert.ToInt32(universiteCombo.SelectedItem.Value);
            fakulte.FakulteGuncelle(txtFakulteAdi.Text, universiteID, id);
            Response.Redirect("/fakulte/fakulte_listesi.aspx");
        }
    }
}