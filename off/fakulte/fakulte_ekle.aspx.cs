using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace off.fakulte
{
    public partial class fakulte_ekle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) //kaydede basılmamıssa yap
            {
                //datasetten universiteler tablosunu alip verileri cekicez ve dropdown ile baglicaz
                DataSet1TableAdapters.universiteTableAdapter univ = new DataSet1TableAdapters.universiteTableAdapter();

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

            }
            



        }
        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.fakulteTableAdapter fakulte = new DataSet1TableAdapters.fakulteTableAdapter();

            int universiteID = Convert.ToInt32(universiteCombo.SelectedItem.Value);

            fakulte.FakulteEkle(txtFakulteAdi.Text, universiteID);
            Response.Redirect("/fakulte/fakulte_listesi.aspx");
        }
    }
}