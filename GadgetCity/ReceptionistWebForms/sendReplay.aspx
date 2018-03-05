<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sendReplay.aspx.cs" Inherits="GadgetCity.sendReplay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../Content/Site.css" />
    <link rel="stylesheet" href="../Content/bootstrap.css" />
    <link rel="stylesheet" href="../Content/bootstrap.min.css" />
    <link rel="stylesheet" href="../Content/bootstrap-theme.min.css" />
    <script src="../Scripts/sweetalert.min.js"></script>
</head>
<body style="background-color:#f3f5f8;">
    <form id="sendReplay" name="sendReplay" runat="server">

        <div class="container">
                <div class="row">
                    <div class="col-md-1">
                        <div class="replyCircle text-uppercase">
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
                <p class="ClientMessage" id="InqMessage" runat="server"></p>
                <p class="ClientEmail" id="InqEmail" runat="server"></p>
                <asp:TextBox placeholder="Enter Replay" CssClass="replay_messageBox" ID="RepMessage" runat="server" TextMode="MultiLine"></asp:TextBox>
                <asp:Button ID="sendEmail" OnClick="sendEmail_Click" runat="server" Text="Replay" CssClass="butto_blue" />
              </div>
        </div>

    </form>
    <script src="../Scripts/jquery-3.3.1.min.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>
</body>
</html>
