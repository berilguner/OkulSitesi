using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace off.bolum
{
    public partial class bolum_ekle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                DataSet1TableAdapters.universiteTableAdapter univ = new DataSet1TableAdapters.universiteTableAdapter();
                DataSet1TableAdapters.fakulteTableAdapter fakulte = new DataSet1TableAdapters.fakulteTableAdapter();

                //sayfa her yenilendiginde icerisindeki elemanlari temizle drop listin
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
            }

        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.bolumTableAdapter bolum = new DataSet1TableAdapters.bolumTableAdapter();

            int universiteID = Convert.ToInt32(universiteCombo.SelectedItem.Value);
            int fakulteID = Convert.ToInt32(fakulteCombo.SelectedItem.Value);

            //bolum.BolumEkle(txtBolumAdi.Text, universiteID);
            bolum.BolumEkle(txtBolumAdi.Text, fakulteID);
            Response.Redirect("/bolum/bolum_listesi.aspx");

           


        }
    }
}