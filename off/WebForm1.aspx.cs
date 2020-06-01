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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["user"] != null)
            {
                Response.Redirect("/universite/universite_listesi.aspx");
            }

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connect"].ToString());
            con.Open();
            string query = "select count(*) from tbluser where user_name='"+txtuser.Text+"'and pass='"+txtpass.Text+"'";

            SqlCommand cmd = new SqlCommand(query, con);
            string output = cmd.ExecuteScalar().ToString();

            if(output == "1")
            {
                Session["user"] = txtuser.Text;
                Response.Redirect("/universite/universite_listesi.aspx");
            }
            else
            {
                Label1.Text = "Kullanıcı veya Şifre Yanlış...";
                Label1.ForeColor = System.Drawing.Color.Red;
                //Response.Write("Kullanıcı veya Şifre Yanlış...");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
                Response.Redirect("~/WebForm2.aspx");
         

        }
    }
}