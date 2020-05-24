using System;
using System.Collections.Generic;
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

      
    }
}