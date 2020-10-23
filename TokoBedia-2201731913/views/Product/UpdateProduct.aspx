<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateProduct.aspx.cs" Inherits="TokoBedia_2201731913.views.updateProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <div><h1>Update Product</h1></div>
        <div>
            <h2>
                <asp:Label ID="prodName" runat="server" Text="Label"></asp:Label>
                &emsp;
                <asp:Label ID="prodPrice" runat="server" Text="Label"></asp:Label>
                &emsp;
                <asp:Label ID="ProdStock" runat="server" Text="Label"></asp:Label>
            </h2>
        </div>
        <br />
        <div>
            <asp:Label ID="Label4" runat="server" Text="Product ID: "></asp:Label>
            <asp:TextBox ID="productIDTxt" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Name: "></asp:Label>
            <asp:TextBox ID="productNameTxt" runat="server"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="Label2" runat="server" Text="Price: "></asp:Label>
            <asp:TextBox ID="productPriceTxt" runat="server"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="Label3" runat="server" Text="Stock: "></asp:Label>
            <asp:TextBox ID="stockProductTxt" runat="server"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
        </div>
        <br />
        <div>
            <asp:Button ID="Button1" runat="server" Text="Update Product" OnClick="Button1_Click" />
        </div>

    </div>
    </form>
</body>
</html>
