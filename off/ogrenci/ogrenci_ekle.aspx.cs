using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace off.ogrenci
{
    public partial class ogrenci_ekle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataSet1TableAdapters.universiteTableAdapter univ = new DataSet1TableAdapters.universiteTableAdapter();
                DataSet1TableAdapters.fakulteTableAdapter fakulte = new DataSet1TableAdapters.fakulteTableAdapter();
                DataSet1TableAdapters.bolumTableAdapter bolum = new DataSet1TableAdapters.bolumTableAdapter();

                universiteCombo.Items.Clear();
                universiteCombo.Items.Add(new ListItem("Üniversite Seçiniz...", ""));
                //bunun veritabanına baglanıp baglanmamasını kontrol edebilmemiz icin ozelligin true olması lazım
                universiteCombo.AppendDataBoundItems = true;
                universiteCombo.DataSource = univ.UniversiteListesiGetir(); //veri kaynagını sectik
                                                                            //hangi alanın gozukmesini istiyosak onu suraya yazıyoruz
                universiteCombo.DataTextField = "universite_adi";
                //universite id value degerini belirledik, kaydedilecek alanı
                universiteCombo.DataValueField = "universite_id";
                universiteCombo.DataBind(); //universiteComboyu bagladik

                fakulteCombo.Items.Clear();
                fakulteCombo.Items.Add(new ListItem("Fakülte Seçiniz...", ""));
                fakulteCombo.AppendDataBoundItems = true;
                fakulteCombo.DataSource = fakulte.FakulteListesiGetir();
                fakulteCombo.DataTextField = "fakulte_adi";
                fakulteCombo.DataValueField = "fakulte_id";
                fakulteCombo.DataBind();

                bolumCombo.Items.Clear();
                bolumCombo.Items.Add(new ListItem("Bölüm Seçiniz...", ""));
                bolumCombo.AppendDataBoundItems = true;
                bolumCombo.DataSource = bolum.BolumListesiGetir();
                bolumCombo.DataTextField = "bolum_adi";
                bolumCombo.DataValueField = "bolum_id";
                bolumCombo.DataBind();
            }

        }
        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.ogrenciTableAdapter ogrenci = new DataSet1TableAdapters.ogrenciTableAdapter();

            int universiteID = Convert.ToInt32(universiteCombo.SelectedItem.Value);
            int fakulteID = Convert.ToInt32(fakulteCombo.SelectedItem.Value);
            int bolumID = Convert.ToInt32(bolumCombo.SelectedItem.Value);

            //bolum.BolumEkle(txtBolumAdi.Text, universiteID);
            //bolum.BolumEkle(txtBolumAdi.Text, fakulteID);
            ogrenci.OgrenciEkle(txtOgrenciAdi.Text, bolumID);
            Response.Redirect("/ogrenci/ogrenci_listesi.aspx");




        }
    }
}