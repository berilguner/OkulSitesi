using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace off.bolum
{
    public partial class bolum_listesi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.bolumTableAdapter bolum = new DataSet1TableAdapters.bolumTableAdapter();

            bolumList.DataSource = bolum.BolumListesiGetir();
            bolumList.DataBind();

        }

        public string fakulteAdiGetir(int fakulte_id)
        {

            //datasetten veritabanına baglanip ilgili idye bagli üni adını,kaydını cekmem lazım
            DataSet1TableAdapters.fakulteTableAdapter fakulte = new DataSet1TableAdapters.fakulteTableAdapter();

            string fakulteAdi = "";

            try
            {
               fakulteAdi = fakulte.FakulteGetir(fakulte_id)[0].fakulte_adi; //unive baglanip o sırada hangi fakulte listeleniyosa o fakulteye ait olan universiteyi getirecegim icin bana bir tane idsini bildigim bi universite lazım o yuzden sadece universitegetiri sectik ve buradan gonderdigim universite idyi cekicem. ve getirilen kayıttan ilk sıradakini secip onun üniversite adını alicam
            }
            catch
            {
                fakulteAdi = "Fakülte Kayıtlardan Silinmiş!";
            }

            return fakulteAdi;
        }

        protected void ButSearch_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["okul_Ogrenci"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand();
            string sqlquery = "select * from [dbo].[bolum] where bolum_adi like '%'+@bolum_adi+'%'";
            sqlcomm.CommandText = sqlquery;
            sqlcomm.Connection = sqlconn;
            sqlcomm.Parameters.AddWithValue("bolum_adi", Txtsearch.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            sda.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Session["user"] = null;
            Response.Redirect("/WebForm1.aspx");

        }
    }
}