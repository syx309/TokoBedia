<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewPaymentType.aspx.cs" Inherits="TokoBedia_2201731913.views.ViewPaymentType" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="tablePaymentType" runat="server" OnRowDeleting="tablePaymentType_RowDeleting" OnRowUpdating="tablePaymentType_RowUpdating" >
            <Columns>
                <asp:ButtonField ButtonType="Button" CommandName="Update" Text="Update" />
                <asp:ButtonField ButtonType="Button" CommandName="Delete" Text="Delete" />
            </Columns>
        </asp:GridView>
    </div>
        <br />
    <div>
        <asp:Button ID="Button1" runat="server" Text="Add New Payment Type" OnClick="Button1_Click" />
    </div>
    </form>
</body>
</html>
