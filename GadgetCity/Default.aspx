<%@ Page Title="GadgetCity" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GadgetCity._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <div style="margin:0;width:100%;padding:0" class="container-fluid">
     <div style="margin:0;padding:0" id="myCarousel" class="carousel slide" data-ride="carousel">
    <!-- Wrapper for slides -->
    <div style="padding:0" class="carousel-inner">
      <div class="item active">
        <img  class="img img-responsive" src="images/main-gal/1.jpg" alt="Los Angeles" style="width:100%"/>
      </div>

      <div class="item">
        <img  class="img img-responsive" src="images/main-gal/2.jpg" alt="Chicago"  style="width:100%"/>
      </div>
    
      <div class="item">
        <img  class="img img-responsive" src="images/main-gal/3.jpg" alt="New york"  style="width:100%"/>
      </div>

        <div class="item">
        <img  class="img img-responsive" src="images/main-gal/4.jpg" alt="New york"  style="width:100%"/>
      </div>
        <div class="item">
        <img  class="img img-responsive" src="images/main-gal/5.jpg" alt="New york"  style="width:100%"/>
      </div>
    </div>
  </div>
    </div>
    <asp:Panel ID="viewBrand" runat="server"  style="margin:0;width:100%;padding:0" CssClass="container-fluid"></asp:Panel>
    <div id="viewBrandDiv" runat="server" style="margin:0;width:100%;padding:0" class="container-fluid">
        
    </div>
</asp:Content>
