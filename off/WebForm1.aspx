<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="off.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>

        body{
            background:#1d56ec;
        }

        .formclass

        {
            padding:20px;
            margin:0px auto;
            background:#fff;
            width:200px;
        }

        h2 {
            text-align:center;
        }

        .input {

            padding:2px;
            

            width:100%;
        }






    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="formclass">
            <h2>GİRİŞ SAYFASI</h2>

            <asp:TextBox ID="txtuser" CssClass="input" placeholder="Kullanıcı Adı" runat="server"></asp:TextBox><br /><br />
            <asp:TextBox ID="txtpass" CssClass="input" placeholder="Parola" TextMode="Password" runat="server"></asp:TextBox><br /><br />

            <asp:Button ID="btnlogin" CssClass="input" width="100%" runat="server" Text="GİRİŞ" OnClick="btnlogin_Click" />
        </div>
    </form>
</body>
</html>
