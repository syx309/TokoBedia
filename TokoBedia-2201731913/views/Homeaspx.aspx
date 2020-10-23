<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Homeaspx.aspx.cs" Inherits="TokoBedia_2201731913.views.Homeaspx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        div{
            text-align : center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Welcome <asp:Label ID="Label1" runat="server" Text=""></asp:Label>!</h1>
    </div>
    <div>
        Your User ID : <asp:Label ID="userID" runat="server" Text=""></asp:Label>
    </div>
        <br />
    <div style="width:475px; margin-left:auto; margin-right:auto;">
        <asp:GridView ID="tableProduct" runat="server" OnRowCommand="tableProduct_RowCommand">
            <Columns>
                <asp:ButtonField ButtonType="Button" CommandName="Other" Text="Add to Cart" />
            </Columns>
        </asp:GridView>
    </div>
        <br />
    <div>
        <asp:LinkButton ID="loginBtn" runat="server" OnClick="loginBtn_Click">Login</asp:LinkButton>
        <asp:LinkButton ID="logoutBtn" runat="server" OnClick="logoutBtn_Click">Logout</asp:LinkButton>
        &emsp;&emsp;
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">View Product</asp:LinkButton>
        &emsp;&emsp;
        <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">View Profile</asp:LinkButton>
    </div>
        <br />
    <div>
        <asp:LinkButton ID="viewUserBtn" runat="server" OnClick="viewUserBtn_Click" >View User</asp:LinkButton>
        &emsp;&emsp;
        <asp:LinkButton ID="insertProdBtn" runat="server" OnClick="insertProdBtn_Click" >Insert Product</asp:LinkButton>
        &emsp;&emsp;
        <asp:LinkButton ID="UpdateProdBtn" runat="server" OnClick="updateProdBtn_Click" >Update Product</asp:LinkButton>
    </div>
        <br />
     <div>
        <asp:LinkButton ID="viewPayTypeBtn" runat="server" OnClick="viewPayTypeBtn_Click"  >View Payment Type</asp:LinkButton>
        &emsp;&emsp;
        <asp:LinkButton ID="InsertPayTypeBtn" runat="server" OnClick="InsertPayTypeBtn_Click"  >Insert Payment Type</asp:LinkButton>
        &emsp;&emsp;
        <asp:LinkButton ID="UpdatePayTypeBtn" runat="server" OnClick="UpdatePayTypeBtn_Click"  >Update Payment Type</asp:LinkButton>
    </div>

        <br />
    <div>
        <asp:LinkButton ID="viewPTBtn" runat="server" OnClick="viewPTBtn_Click">View Product Type</asp:LinkButton>
        &emsp;&emsp;
        <asp:LinkButton ID="insertPTBtn" runat="server" OnClick="insertPTBtn_Click" >Insert Product Type</asp:LinkButton>
        &emsp;&emsp;
        <asp:LinkButton ID="updatePTBtn" runat="server" OnClick="updatePTBtn_Click"  >Update Product Type</asp:LinkButton>
    </div>
        <br />
    <div>
        <asp:LinkButton ID="viewCartBtn" runat="server" OnClick="viewCartBtn_Click">View Cart</asp:LinkButton>
        &emsp;&emsp;
        <asp:LinkButton ID="viewTransactionHistoryBtn" runat="server" OnClick="viewTransactionHistoryBtn_Click" >View Transaction History</asp:LinkButton>
        &emsp;&emsp;
        <asp:LinkButton ID="viewTransactionReport" runat="server" OnClick="viewTransactionReport_Click"  >View Transaction Report</asp:LinkButton>
    </div>
    </form>
</body>
</html>
