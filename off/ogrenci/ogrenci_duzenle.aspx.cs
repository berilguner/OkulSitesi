using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace off.ogrenci
{
    public partial class ogrenci_duzenle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                DataSet1TableAdapters.ogrenciTableAdapter ogrenci = new DataSet1TableAdapters.ogrenciTableAdapter();
                DataSet1TableAdapters.bolumTableAdapter bolum = new DataSet1TableAdapters.bolumTableAdapter();
                //DataSet1TableAdapters.fakulteTableAdapter fakulte = new DataSet1TableAdapters.fakulteTableAdapter();
                //DataSet1TableAdapters.universiteTableAdapter univ = new DataSet1TableAdapters.universiteTableAdapter();

                int id = Convert.ToInt32(Request.QueryString["id"]);

                try
                {
                    // int universiteID = fakulte.FakulteGetir(id)[0].universite_id;
                    int bolumID = ogrenci.OgrenciGetir(id)[0].bolum_id;
                    //int fakulteID = bolum.BolumGetir(id)[0].fakulte_id;
                    //int universiteID = fakulte.FakulteGetir(id)[0].universite_id;
                    string ogrenciAdi = ogrenci.OgrenciGetir(id)[0].ogrenci_adi;
                    // string universiteAdi = univ.UniversiteGetir(universiteID)[0].universite_adi;
                    string bolumAdi = bolum.BolumGetir(bolumID)[0].bolum_adi;
                    //string fakulteAdi = fakulte.FakulteGetir(fakulteID)[0].fakulte_adi;
                    //string universiteAdi = univ.UniversiteGetir(universiteID)[0].universite_adi;

                    txtOgrenciAdi.Text = ogrenciAdi;


                    // universiteCombo.Items.Clear();
                    //universiteCombo.DataSource = univ.UniversiteListesiGetir();
                    //universiteCombo.DataTextField = "universite_adi";
                    //universiteCombo.DataValueField = "universite_id";
                    //universiteCombo.DataBind();


                    bolumCombo.Items.Clear();
                    bolumCombo.DataSource = bolum.BolumListesiGetir();
                    bolumCombo.DataTextField = "bolum_adi";
                    bolumCombo.DataValueField = "bolum_id";
                    bolumCombo.DataBind();

                    //universiteCombo.SelectedIndex = universiteCombo.Items.IndexOf(universiteCombo.Items.FindByText(universiteAdi));
                    bolumCombo.SelectedIndex = bolumCombo.Items.IndexOf(bolumCombo.Items.FindByText(bolumAdi));



                }
                catch
                {


                }

            }

        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.ogrenciTableAdapter ogrenci = new DataSet1TableAdapters.ogrenciTableAdapter();
            //DataSet1TableAdapters.bolumTableAdapter bolum = new DataSet1TableAdapters.bolumTableAdapter();
            //DataSet1TableAdapters.fakulteTableAdapter fakulte = new DataSet1TableAdapters.fakulteTableAdapter();
            //DataSet1TableAdapters.universiteTableAdapter univ = new DataSet1TableAdapters.universiteTableAdapter();

            int id = Convert.ToInt32(Request.QueryString["id"]);
            //int universiteID = Convert.ToInt32(universiteCombo.SelectedItem.Value);
            int bolumID = Convert.ToInt32(bolumCombo.SelectedItem.Value);
            //int fakulteID = Convert.ToInt32(fakulteCombo.SelectedItem.Value);
            //int universiteID = Convert.ToInt32(universiteCombo.SelectedItem.Value);
            //bolum.BolumGuncelle(txtBolumAdi.Text, fakulteID, id);
            ogrenci.OgrenciGuncelle(txtOgrenciAdi.Text, bolumID, id);
            //bolum.BolumGuncelle(txtOgrenciAdi.Text, fakulteID, id);
            //fakulte.FakulteGuncelle(txtOgrenciAdi.Text, universiteID, id);
            Response.Redirect("/ogrenci/ogrenci_listesi.aspx");
        }
    }
}