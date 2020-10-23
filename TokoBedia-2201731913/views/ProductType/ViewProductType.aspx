<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewProductType.aspx.cs" Inherits="TokoBedia_2201731913.views.ViewProductType" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="tableProductType" runat="server" OnRowDeleting="tableProductType_RowDeleting" OnRowUpdating="tableProductType_RowUpdating" >
            <Columns>
                <asp:ButtonField ButtonType="Button" CommandName="Update" Text="Update" />
                <asp:ButtonField ButtonType="Button" CommandName="Delete" Text="Delete" />
            </Columns>
        </asp:GridView>
    </div>
        <br />
    <div>
        <asp:linkbutton ID="insertBtn" runat="server" OnClick="insertBtn_Click">Insert Product Type</asp:linkbutton>
        &emsp;&emsp;
    </div>
    </form>
</body>
</html>
