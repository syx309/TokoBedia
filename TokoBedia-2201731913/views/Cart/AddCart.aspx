<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddCart.aspx.cs" Inherits="TokoBedia_2201731913.views.AddCart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>
        <asp:Label ID="Label1" runat="server" Text="Product Name: "></asp:Label>
        <asp:Label ID="nameLabel" runat="server" ></asp:Label>
        </h2>
    </div>   
    <div>
        <h2>
        <asp:Label ID="Label2" runat="server" Text="Stock: "></asp:Label>
        <asp:Label ID="stockLabel" runat="server"></asp:Label>
        </h2>
    </div>
    <div>
        <h2>
        <asp:Label ID="Label3" runat="server" Text="Price: "></asp:Label>
        <asp:Label ID="priceLabel" runat="server"></asp:Label>
        </h2> 
    </div>
        <br />
    <div>
        <asp:TextBox ID="quantityTxt" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="lblError" runat="server"></asp:Label>
    </div>
        <br />
    <div>
        <asp:Button ID="Button1" runat="server" Text="Add to Cart" OnClick="AddCartBtn_Click"/>
    </div>
    </form>
</body>
</html>
