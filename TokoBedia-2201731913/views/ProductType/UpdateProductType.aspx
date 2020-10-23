<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateProductType.aspx.cs" Inherits="TokoBedia_2201731913.views.UpdateProductType" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div><h1>Update Product Type</h1></div>

        <div>
            <h2>
                <asp:Label ID="prodName" runat="server" Text="Label"></asp:Label>
                &emsp;
                <asp:Label ID="prodDesc" runat="server" Text="Label"></asp:Label>
            </h2>
        </div>
    <div>
        <asp:Label ID="Label1" runat="server" Text="Product Type ID: "></asp:Label>
        <asp:TextBox ID="idTxt" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label2" runat="server" Text="Product Type Name:"></asp:Label>
        <asp:TextBox ID="nameTxt" runat="server"></asp:TextBox>
    </div>
        <div>
        <asp:Label ID="Label3" runat="server" Text="Product Type Description: "></asp:Label>
        <asp:TextBox ID="descTxt" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
    </div>
        <br />
    <div>
        <asp:Button ID="Button1" runat="server" Text="Update Product Type" OnClick="Button1_Click" />
    </div>
    </form>
</body>
</html>
