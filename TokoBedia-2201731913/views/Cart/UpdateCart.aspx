<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateCart.aspx.cs" Inherits="TokoBedia_2201731913.views.UpdateCart" %>

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
            <div>
                <h2>
                    Product Name: 
                    <asp:Label ID="prodName" runat="server" Text="Label"></asp:Label>
                </h2>
            </div>
            <div>
                <h2>
                    Product Price: 
                    <asp:Label ID="prodPrice" runat="server" Text="Label"></asp:Label>
                </h2>
            </div>    
            <div>
                <h2>
                    Product Stock: 
                    <asp:Label ID="prodStock" runat="server" Text="Label"></asp:Label>
                </h2> 
            </div>
        </div>
        <br />
        <div>
            <asp:Label ID="Label3" runat="server" Text="Quantity in your Cart: "></asp:Label>
            <asp:TextBox ID="quantityTxt" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
        </div>
        <br />
        <div>
            <asp:Button ID="Button1" runat="server" Text="Update Cart" OnClick="Button1_Click" />
        </div>

    </div>
    </form>
</body>
</html>
