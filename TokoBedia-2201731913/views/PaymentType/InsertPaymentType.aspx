<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertPaymentType.aspx.cs" Inherits="TokoBedia_2201731913.views.InsertPaymentType" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="tablePaymentType" runat="server" ></asp:GridView>
    </div>
        <br />
    <div>
        <asp:Label ID="Label1" runat="server" Text="New Payment Type: "></asp:Label>
        <asp:TextBox ID="paytypeTxt" runat="server"></asp:TextBox>
    </div>
        <br />
    <div>
        <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:Button ID="Button1" runat="server" Text="Add New" OnClick="Button1_Click" />
    </div>
    </form>
</body>
</html>
