<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="off.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="/assets/css/bootstrap.min.css" rel="stylesheet" />
     <script src="/assets/js/bootstrap.min.js" ></script>
    <style>

        body {
            margin: 0;
            padding: 0;
            background-image: url('k.jpg');
            background-size:cover;
            font-family:sans-serif;
            
        }
      

        .formclass {
            padding: 20px;
            margin: 0px auto;
            background: #fff;
            width: 200px;
        }

        h2 {
            text-align:center;
        }

        .input {

            padding:2px;
            font-family:sans-serif;
            width:100%;
        }
        .loginbox {
            position:absolute;
            top:50%;
            left:50%;
            transform: translate(-50%,-50%);
            width:350px;
            height:420px;
            padding:80px 40px;
            box-sizing: border-box;
            background: rgba(0,0,0,0.5);
        }






    </style>
</head>
<body>
    <form id="form1" runat="server">
         
        <div class="loginbox">
          
        
            <h2 class="input">YÖNETİCİ GİRİŞ</h2>

            <asp:TextBox ID="txtuser" CssClass="input" placeholder="Kullanıcı Adı" runat="server"></asp:TextBox><br /><br />
            <asp:TextBox ID="txtpass" CssClass="input" placeholder="Parola" TextMode="Password" runat="server"></asp:TextBox><br /><br />

           


            <asp:Button ID="btnlogin" CssClass="btn btn-light" width="100%" runat="server" Text="GİRİŞ" OnClick="btnlogin_Click" /><br /><br />
            <asp:Button ID="Button1" CssClass="btn btn-light" Width="100%" runat="server" Text="ÖĞRETİM ÜYESİ GİRİŞ" OnClick="Button1_Click"  /><br /><br />
            <asp:Label ID="Label1" runat="server" Font-Bold="True"></asp:Label>
        </div>
       
      <script src="vendor/jquery/jquery.min.js"></script>
  <script src="vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
       
    </form>

      </body>
</html>
