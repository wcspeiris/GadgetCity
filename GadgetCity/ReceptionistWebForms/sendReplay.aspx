<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sendReplay.aspx.cs" Inherits="GadgetCity.sendReplay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../Content/Site.css" />
    <link rel="stylesheet" href="../Content/bootstrap.css" />
    <link rel="stylesheet" href="../Content/bootstrap.min.css" />
    <link rel="stylesheet" href="../Content/bootstrap-theme.min.css" />
    <link rel="stylesheet" href="../Scripts/sweetalert.min.js" />
</head>
<body style="background-color:#f3f5f8;">
    <form id="form1" runat="server">

        <div class="container">
                <div class="row">
                    <div class="col-md-1">
                        <div class="replyCircle">
                        <p class="ClientNS" id="InqNameShort" runat="server"></p>
                    </div>
                        
                    <div class="col-md-5" style="background-color:;">
                        <p class="ClientNameReplay" id="InqName" runat="server"></p>
                        <p class="ClientDate" id="InqDate" runat="server"></p>
                    </div>
                    </div>
                  </div>
            <hr />
            <div class="row">
                <p class="ClientEmail" id="InqEmail" runat="server"></p>
                <p class="ClientMessage" id="InqMessage" runat="server"></p>
                <hr />
                <asp:TextBox CssClass="replay_messageBox" ID="Message" runat="server" TextMode="MultiLine"></asp:TextBox>
                <asp:Button ID="sendEmail" runat="server" Text="Send" CssClass="butto_blue" />
                <asp:Label ID="inqSuccess" runat="server">Email Sent</asp:Label>
            </div>
        </div>

    </form>
    <script src="../Scripts/jquery-3.3.1.min.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>
</body>
</html>
