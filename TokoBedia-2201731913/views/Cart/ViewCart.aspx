<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewCart.aspx.cs" Inherits="TokoBedia_2201731913.views.ViewCart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="tableCart" runat="server" OnRowDeleting="tableProductType_RowDeleting" OnRowUpdating="tableProductType_RowUpdating" >
            <Columns>
                <asp:ButtonField ButtonType="Button" CommandName="Update" Text="Update" />
                <asp:ButtonField ButtonType="Button" CommandName="Delete" Text="Delete" />
            </Columns>
        </asp:GridView>
    </div>
        <br />
    <div>
        <asp:Label ID="Label1" runat="server" Text="Grandtotal: "></asp:Label>
        <asp:Label ID="grandTotalTxt" runat="server"></asp:Label>   
    </div>
        <br />
    <div>
        <asp:Button ID="Button1" runat="server" Text="CheckOut Cart" OnClick="CheckoutBtn"/>
    </div>
        <br />
    <div>
        <asp:GridView ID="tablePaymentType" runat="server" >
        </asp:GridView>
    </div>
        <br />
    <div>
        <asp:Label ID="Label2" runat="server" Text="Input Payment Type ID: "></asp:Label>
        <asp:TextBox ID="PaymentTypeId" runat="server"></asp:TextBox>
    </div>
        <br />
    <div>
         <asp:Label ID="lblErrortxt" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
