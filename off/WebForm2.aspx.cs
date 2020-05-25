using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace off
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["okul_ConnectionString"].ConnectionString);
        SqlCommand cmd = null;
        SqlDataReader dr = null;

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }


        protected void btnlogin_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select Password from Login where Username = '" + txtUsername.Text + "'", con);
            con.Open();
            dr = cmd.ExecuteReader();
            bool flag = false;
            while (dr.Read())
            {
                if (dr[0].Equals(txtPassword.Text))
                {
                    Session["username"] = txtUsername.Text;
                    //lblMsg.Text = "Giriş Başarılı...";
                    //lblMsg.ForeColor = System.Drawing.Color.Green;
                    Response.Redirect("/ogrenci/ogrenci_listesi.aspx");
                    flag = true;
                }
            }
            if (!flag)
            {
                lblMsg.Text = "Kullanıcı veya Şifre Yanlış... ";
                lblMsg.ForeColor = System.Drawing.Color.Red;
            }
            con.Close();


        }
    }
}