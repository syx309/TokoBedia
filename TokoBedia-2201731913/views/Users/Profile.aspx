<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="TokoBedia_2201731913.views.Users.Profile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
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
        <asp:Button ID="Button1" runat="server" Text="Update Profile" OnClick="updateBtn_Click"/>
        &emsp;&emsp;&emsp;&emsp;&emsp;
        <asp:Button ID="Button2" runat="server" Text="Change Password" OnClick="changePass_Click"/>
    </div>
        <br />
    </form>
</body>
</html>
