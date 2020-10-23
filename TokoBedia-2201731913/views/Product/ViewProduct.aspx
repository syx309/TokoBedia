<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewProduct.aspx.cs" Inherits="TokoBedia_2201731913.views.ViewProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="tableProduct" runat="server" OnRowDeleting="tableProduct_RowDeleting" OnRowUpdating="tableProduct_RowUpdating" OnRowCommand="tableProduct_RowCommand">
            <Columns>
                <asp:ButtonField ButtonType="Button" CommandName="Update" Text="Update" />
                <asp:ButtonField ButtonType="Button" CommandName="Delete" Text="Delete" />
                <asp:ButtonField ButtonType="Button" CommandName="Other" Text="Add to Cart" />
            </Columns>
        </asp:GridView>
        <br />
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Login</asp:LinkButton>
    </div>

    <br />
    <div>
        <asp:LinkButton ID="insertBtn" runat="server" OnClick="insertBtn_Click">Insert Product</asp:LinkButton>
    </div>

    </form>
</body>
</html>
