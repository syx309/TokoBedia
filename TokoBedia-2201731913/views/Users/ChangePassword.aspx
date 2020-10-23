<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="TokoBedia_2201731913.views.ChangePassword" %>

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
        <h2>Update Password</h2>
    </div>
        <br />
    <div>
        <asp:Label ID="Label1" runat="server" Text="Old Password: "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" TextMode="Password"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label2" runat="server" Text="New Password(minimum 5 character):"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label3" runat="server" Text="Confirm Your New Password: "></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
    </div>
        <br />
    <div>
        <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
    </div>
        <br />
    <div>
        <asp:Button ID="updateBtn" runat="server" Text="Update Password" OnClick="updateBtn_Click" />
    </div>
    </form>
</body>
</html>
