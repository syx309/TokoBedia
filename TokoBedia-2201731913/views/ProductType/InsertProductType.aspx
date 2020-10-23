<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertProductType.aspx.cs" Inherits="TokoBedia_2201731913.views.InsertProductType" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="tableProductType" runat="server" ></asp:GridView>
    </div>
        <br />
    <div>
        <asp:Label ID="Label1" runat="server" Text="Name: "></asp:Label>
        <asp:TextBox ID="productTypeNameTxt" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label2" runat="server" Text="Description: "></asp:Label>
        <asp:TextBox ID="descriptionTxt" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
    </div>
        <br />
    <div>
        <asp:Button ID="Button1" runat="server" Text="Insert Product Type" OnClick="Button1_Click" />
    </div>
    </form>
</body>
</html>
