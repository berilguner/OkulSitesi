<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="fakulte_listesi.aspx.cs" Inherits="off.fakulte.fakulte_listesi" %>



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
                     <form id="form1" runat="server">
                         <h3>Fakülte Listesi</h3>
                         <table class="table table-bordered table-hover"> <!-- baslık ve icerik olarak tabloyu iki kısma ayırıyoruz -->
                             <thead> <!-- baslıgı belirtiyor baslık yukarıda oluyor-->
                                 <tr> <!-- satır olusturduk-->
                                     <th>ID</th> <!-- satır baslıgı-->
                                     <th>Fakülte Adı</th>
                                     <th>Üniversite Adı</th>
                                     <th>İşlemler</th>


                                 </tr>


                             </thead>
                             <tbody> <!-- icerigin, kayıtların bulundugu yer-->

                                 <!-- tekrarlayan alanları cogaltıyor kendi-->

                                 <asp:Repeater ID="fakulteList" runat="server"> 
                                     <ItemTemplate>
                                         
                                 <tr>  <!-- burdakiler benim fakulte tablomdan gelecek sutunlar-->
                                     <td><%# Eval("fakulte_id") %></td>
                                     <td><%# Eval("fakulte_adi") %></td>
                                     <td><%#universiteAdiGetir(Convert.ToInt32( Eval("universite_id"))) %></td> <!-- metodu cagirdik-->
                                     <td>
                                         <asp:HyperLink NavigateUrl='<%# String.Format("fakulte_sil.aspx?id={0}", Eval("fakulte_id")) %>' runat="server" class="btn btn-danger">Sil</asp:HyperLink>
                                         <asp:HyperLink NavigateUrl='<%# String.Format("fakulte_duzenle.aspx?id={0}", Eval("fakulte_id")) %>' runat="server" class="btn btn-success">Güncelle</asp:HyperLink>
                                        
                                 </tr>

                                     </ItemTemplate>
                                 </asp:Repeater>



                             </tbody>
 
                         </table>

                         <a class="btn btn-primary" href ="/fakulte/fakulte_ekle.aspx">Fakülte Ekle</a><br /><br />
                         
   
        <asp:Button ID="Button1" CssClass="btn btn-light" runat="server" OnClick="Button1_Click" Text="ÇIKIŞ" />

        
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




</body>
</html>

