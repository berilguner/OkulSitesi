using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace off.bolum
{
    public partial class bolum_duzenle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                DataSet1TableAdapters.bolumTableAdapter bolum = new DataSet1TableAdapters.bolumTableAdapter();
                DataSet1TableAdapters.fakulteTableAdapter fakulte = new DataSet1TableAdapters.fakulteTableAdapter();
                //DataSet1TableAdapters.universiteTableAdapter univ = new DataSet1TableAdapters.universiteTableAdapter();

                int id = Convert.ToInt32(Request.QueryString["id"]);

                try
                {
                    // int universiteID = fakulte.FakulteGetir(id)[0].universite_id;
                    int fakulteID = bolum.BolumGetir(id)[0].fakulte_id;
                    string bolumAdi = bolum.BolumGetir(id)[0].bolum_adi;
                    // string universiteAdi = univ.UniversiteGetir(universiteID)[0].universite_adi;
                    string fakulteAdi = fakulte.FakulteGetir(fakulteID)[0].fakulte_adi;

                    txtBolumAdi.Text = bolumAdi;

                    // universiteCombo.Items.Clear();
                    //universiteCombo.DataSource = univ.UniversiteListesiGetir();
                    //universiteCombo.DataTextField = "universite_adi";
                    //universiteCombo.DataValueField = "universite_id";
                    //universiteCombo.DataBind();

                    fakulteCombo.Items.Clear();
                    fakulteCombo.DataSource = fakulte.FakulteListesiGetir();
                    fakulteCombo.DataTextField = "fakulte_adi";
                    fakulteCombo.DataValueField = "fakulte_id";
                    fakulteCombo.DataBind();

                    //universiteCombo.SelectedIndex = universiteCombo.Items.IndexOf(universiteCombo.Items.FindByText(universiteAdi));
                    fakulteCombo.SelectedIndex = fakulteCombo.Items.IndexOf(fakulteCombo.Items.FindByText(fakulteAdi));

                }
                catch
                {


                }

            }

        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.bolumTableAdapter bolum = new DataSet1TableAdapters.bolumTableAdapter();

            int id = Convert.ToInt32(Request.QueryString["id"]);
            //int universiteID = Convert.ToInt32(universiteCombo.SelectedItem.Value);
            int fakulteID = Convert.ToInt32(fakulteCombo.SelectedItem.Value);
            //bolum.BolumGuncelle(txtBolumAdi.Text, fakulteID, id);
            bolum.BolumGuncelle(txtBolumAdi.Text, fakulteID, id);
            Response.Redirect("/bolum/bolum_listesi.aspx");
        }

    }
}