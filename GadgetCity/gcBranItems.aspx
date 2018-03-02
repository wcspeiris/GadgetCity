<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="gcBranItems.aspx.cs" Inherits="GadgetCity.gcBranItems" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid headerImage">

        <div style="margin-top:2%;" class="row">
            <div class="col-md-2 col-md-offset-3">
                <asp:Image ID="brandImage" runat="server" CssClass="img-responsive img-circle"/>
            </div>
            <div class="col-md-4">
            <h2 style="font-family:Calibri" id="brandNameHead" runat="server" class="HeadrBrancID Text-Uppercase"></h2>
            </div>
        </div>

    </div>
    <div class="container">
        <div class="row">
            <div class="col-md-3">
                <p style="" id="headItile" runat="server" class="bradnNameSide"></p>
                <asp:Label ID="carPartCount" runat="server" Text="Label" CssClass="bradnPartInfo">120 PRODUCTS</asp:Label>
                <hr style="margin-top:5px;margin-bottom:5px;" />
                <p class="typeText">Car Model</p>
                <div id="carList" runat="server">

                </div>
            </div>
            <div class="col-md-9" id="PartList" runat="server" style="padding:10px">
                
            </div>
        </div>
    </div>
    
</asp:Content>