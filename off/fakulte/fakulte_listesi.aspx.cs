using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace off.fakulte
{
    public partial class fakulte_listesi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.fakulteTableAdapter fakulte = new DataSet1TableAdapters.fakulteTableAdapter();

            fakulteList.DataSource = fakulte.FakulteListesiGetir();
            fakulteList.DataBind();

           

        }

        //id'den yola cikip uni ismini getirecek bir metot olusturduk
        public string universiteAdiGetir(int universite_id)
        {

            //datasetten veritabanına baglanip ilgili idye bagli üni adını,kaydını cekmem lazım
            DataSet1TableAdapters.universiteTableAdapter univ = new DataSet1TableAdapters.universiteTableAdapter();

            string universiteAdi = "";

            try
            {
                universiteAdi = univ.UniversiteGetir(universite_id)[0].universite_adi; //unive baglanip o sırada hangi fakulte listeleniyosa o fakulteye ait olan universiteyi getirecegim icin bana bir tane idsini bildigim bi universite lazım o yuzden sadece universitegetiri sectik ve buradan gonderdigim universite idyi cekicem. ve getirilen kayıttan ilk sıradakini secip onun üniversite adını alicam
            }
            catch
            {
                universiteAdi = "Üniversite Kayıtlardan Silinmiş!";
            }

            return universiteAdi;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["user"] = null;
            Response.Redirect("/WebForm1.aspx");
        }
    }
}