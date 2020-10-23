<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdatePaymentType.aspx.cs" Inherits="TokoBedia_2201731913.views.UpdatePaymentType" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>
            <asp:Label ID="PaymentTypeName" runat="server"></asp:Label>
        </h2>
    </div>
    <div>
        <asp:Label ID="Label1" runat="server" Text="Update Payment Type: "></asp:Label>
        <asp:TextBox ID="paytypeTxt" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
    </div>
        <br />
    <div>
        <asp:Button ID="Button1" runat="server" Text="Update" OnClick="Button1_Click" style="height: 35px" />
    </div>
    </form>
</body>
</html>
