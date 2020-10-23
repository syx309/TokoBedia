<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewTransactionHistory.aspx.cs" Inherits="TokoBedia_2201731913.views.ViewTransactionHistory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridTransaction" runat="server"></asp:GridView>
    </div>
        <div>
            <asp:Button ID="ReportBTN" runat="server" Text="Transaction Report" OnClick="ReportBTN_Click" />
        </div>
    </form>
</body>
</html>
