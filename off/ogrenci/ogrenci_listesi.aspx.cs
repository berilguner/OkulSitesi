using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace off.ogrenci
{
    public partial class ogrenci_listesi : System.Web.UI.Page
    {
       // SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["okul_ConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.ogrenciTableAdapter ogrenci = new DataSet1TableAdapters.ogrenciTableAdapter();

            ogrenciList.DataSource = ogrenci.OgrenciListesiGetir();
            ogrenciList.DataBind();

        }

        public string bolumAdiGetir(int bolum_id)
        {
            DataSet1TableAdapters.bolumTableAdapter bolum = new DataSet1TableAdapters.bolumTableAdapter();

            string bolumAdi = "";

            try
            {
                bolumAdi = bolum.BolumGetir(bolum_id)[0].bolum_adi; //unive baglanip o sırada hangi fakulte listeleniyosa o fakulteye ait olan universiteyi getirecegim icin bana bir tane idsini bildigim bi universite lazım o yuzden sadece universitegetiri sectik ve buradan gonderdigim universite idyi cekicem. ve getirilen kayıttan ilk sıradakini secip onun üniversite adını alicam
            }
            catch
            {
                bolumAdi = "Bölüm Kayıtlardan Silinmiş!";
            }

            return bolumAdi;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/off/Views/Student/Index.cshtml");
        }

        protected void ButSearch_Click(object sender, EventArgs e)
        {
           
        }

        // protected void Button1_Click(object sender, EventArgs e)
        // {
        //    string find = "select * from ogrenci where (ogrenci_adi like '%' + @ogrenci_adi + '%')";
        //     SqlCommand comm = new SqlCommand(find, con);
        //     comm.Parameters.Add("@ogrenci_adi", SqlDbType.NVarChar).Value = TextBox1.Text;
        //     con.Open();

        //     comm.ExecuteNonQuery();
        //     SqlDataAdapter da = new SqlDataAdapter();
        //     da.SelectCommand = comm;
        //     DataSet ds = new DataSet();
        //     da.Fill(ds, "ogrenci_adi");
        //    GridView1.DataSource = ds;

        //     con.Close();

        // }
    }
}