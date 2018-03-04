<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InquiryList.aspx.cs" Inherits="GadgetCity.inquireView.InquiryList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid headerImage">

    </div>
    <div  class="container" style="padding:40px">
        <a runat="server" onclick="Ref()" id="ref">sad</a>
        <div class='row'>
            <div id="inqueryView" style="height:84vh;overflow-y: auto;" runat="server" class='col-md-4'>
                
            </div>
            <div class="col-md-8">
                <iframe name="Namegg" class="ReplayWindow"></iframe>
            </div>
        </div>
    </div>
</asp:Content>
