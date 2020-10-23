<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateProfile.aspx.cs" Inherits="TokoBedia_2201731913.views.UpdateProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div>
        <h2>
        <asp:Label ID="Label1" runat="server" Text="Email: "></asp:Label>
        <asp:Label ID="emailLabel" runat="server" ></asp:Label>
        </h2>
    </div>   
    <div>
        <h2>
        <asp:Label ID="Label2" runat="server" Text="Name: "></asp:Label>
        <asp:Label ID="nameLabel" runat="server"></asp:Label>
        </h2>
    </div>
    <div>
        <h2>
        <asp:Label ID="Label3" runat="server" Text="Gender: "></asp:Label>
        <asp:Label ID="genderLabel" runat="server"></asp:Label>
        </h2> 
    </div>
        <br />
    <div>
        <asp:Label ID="Label4" runat="server" Text="Email: "></asp:Label>
        <asp:TextBox ID="emailTxt" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label5" runat="server" Text="Name: "></asp:Label>
        <asp:TextBox ID="nameTxt" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label6" runat="server" Text="Gender: "></asp:Label>
        <asp:RadioButtonList ID="genderBtn" runat="server">
            <asp:ListItem>Male</asp:ListItem>
            <asp:ListItem>Female</asp:ListItem>
        </asp:RadioButtonList>
    </div>
        <br />
    <div>
        <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
    </div>
        <br />
    <div>
        <asp:Button ID="updateBtn" runat="server" Text="Update Profile" OnClick="updateBtn_Click" />
    </div>
    </div>
    </form>
</body>
</html>
