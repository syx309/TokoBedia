<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TokoBedia_2201731913.views.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Email: "></asp:Label>
            <asp:TextBox ID="emailTxt" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Password: "></asp:Label>
            <asp:TextBox ID="passwordTxt" runat="server" TextMode="Password"></asp:TextBox>
        </div>
        <div>
            <asp:CheckBox ID="RememberMe" runat="server" Text="Remember Me"/>
        </div>
        <div>
            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Button ID="loginBtn1" runat="server" Text="Login" OnClick="loginBtn1_Click" />
        </div>
        <div>
            <asp:Label ID="Label4" runat="server" Text="New User?"></asp:Label>
            <asp:LinkButton ID="registerLink" runat="server" OnClick="registerLink_Click">Register</asp:LinkButton>
        </div>
    </div>
    </form>
</body>
</html>
