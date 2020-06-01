<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="bolum_duzenle.aspx.cs" Inherits="off.bolum.bolum_duzenle" %>




<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link href="/assets/css/bootstrap.min.css" rel="stylesheet" />
    <link href="/assets/css/simple-sidebar.css" rel="stylesheet" />

    <script src="https://code.jquery.com/jquery-1.11.3.js" integrity="sha256-IGWuzKD7mwVnNY01LtXxq3L84Tm/RJtNCYBfXZw3Je0=" crossorigin="anonymous"></script>
    <script src="/assets/js/bootstrap.min.js" ></script>
</head>
<body>
   
    <div class="d-flex" id="wrapper">

    <!-- Sidebar -->
    <div class="bg-light border-right" id="sidebar-wrapper">
      <div class="list-group list-group-flush">
     
        <a href="/universite/universite_listesi.aspx" class="list-group-item list-group-item-action bg-light">Üniversite İşlemleri</a>
        <a href="/fakulte/fakulte_listesi.aspx" class="list-group-item list-group-item-action bg-light">Fakülte İşlemleri</a>
        <a href="/bolum/bolum_listesi.aspx" class="list-group-item list-group-item-action bg-light">Bölüm İşlemleri</a>
        <a href="#" class="list-group-item list-group-item-action bg-light">Yardım</a>
        <a href="/WebForm1.aspx" class="list-group-item list-group-item-action bg-light"></a>
      </div>
    </div>
    <!-- /#sidebar-wrapper -->

    <!-- Page Content -->
    <div id="page-content-wrapper">
        <div class="container-fluid">
            <div class="row">
                <div class="col-lg-12">
                     <form id="form2" runat="server">
                         <h3>Bölüm Düzenle</h3>
                       

                           <div class="form-group">
                                <label for="txtFakulteID">Fakülte Adı</label>
                               
                              <asp:DropDownList runat="server" CssClass="form-control" ID="fakulteCombo" AutoPostBack="true" >
                                  
                              </asp:DropDownList>
                          </div>

                          <div class="form-group">
                                <label for="txtBolumAdi">Bölüm Adı</label>
                                <asp:TextBox runat="server" ID="txtBolumAdi" CssClass="form-control" placeholder="" />
                          </div>
                                <asp:Button Text="Kaydet" ID="btnKaydet" CssClass="btn btn-info" runat="server" OnClick="btnKaydet_Click" />
                                <a class="btn btn-danger" href="/bolum/bolum_listesi.aspx">İptal</a> <!--asp yapmamiza gerek yok cunku arka tarafta veritabanıyla bir işimiz yok.-->
                     </form>
                </div>
            </div>
        </div>

    </div>
    <!-- /#page-content-wrapper -->

   

  </div>
  <!-- /#wrapper -->

  <!-- Bootstrap core JavaScript -->
  <script src="vendor/jquery/jquery.min.js"></script>
  <script src="vendor/bootstrap/js/bootstrap.bundle.min.js"></script>

  <!-- Menu Toggle Script -->
  <script>
    $("#menu-toggle").click(function(e) {
      e.preventDefault();
      $("#wrapper").toggleClass("toggled");
    });
  </script>

</body>
</html>



