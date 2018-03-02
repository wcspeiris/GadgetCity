<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="partOrder.aspx.cs" Inherits="GadgetCity.partOrder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container-fluid headerImage">

    </div>
    <div class="container">
        <div class="row">
            <div class="col-md-3  col-md-offset-2">
                <asp:Image ID="Partpicture" runat="server" CssClass="img-responsive"/>
            </div>
            <div style="padding-top:7%" class="col-md-4 text-center">
                <asp:Label CssClass="partTitle" ID="partName" runat="server"></asp:Label>
            </div>
        </div>
        <div class="row">
            <div class="col-md-8 table-responsive col-md-offset-2">
            <table class="table table-hover partInfoTable">
                <tr>
                    <td>
                        Spare Part Category
                    </td>
                    <td>
                        <asp:Label ID="spareCateory" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        Brand
                    </td>
                    <td>
                        <asp:Label ID="SpareBrand" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                       Manufactured Year
                    </td>
                    <td>
                        <asp:Label ID="ManuYear" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        Price
                    </td>
                    <td>
                        <asp:Label ID="sparePrice" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="2"><asp:Label ID="SpareDescri" runat="server" Text="Label"></asp:Label></td>
                </tr>
                <tr>
                    <td colspan="2">
                        <a href="#" class="butto_url">Add To Cart</a>
                    </td>
                </tr>
            </table>
            </div>
        </div>
    </div>
</asp:Content>
