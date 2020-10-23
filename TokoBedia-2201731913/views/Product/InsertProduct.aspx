<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertProduct.aspx.cs" Inherits="TokoBedia_2201731913.views.insertProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        div{
            text-align:center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div><h2>Insert New Product</h2></div>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Name: "></asp:Label>
            <asp:TextBox ID="productNameTxt" runat="server"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="Label3" runat="server" Text="Stock: "></asp:Label>
            <asp:TextBox ID="stockPriceTXT" runat="server"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="Label2" runat="server" Text="Price: "></asp:Label>
            <asp:TextBox ID="productPriceTxt" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
        </div>
        <br />
        <div>
            <asp:Button ID="Button1" runat="server" Text="Submit New Product" OnClick="Button1_Click" />
        </div>
    </div>
    </form>
</body>
</html>
