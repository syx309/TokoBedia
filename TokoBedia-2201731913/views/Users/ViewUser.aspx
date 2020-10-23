<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewUser.aspx.cs" Inherits="TokoBedia_2201731913.views.ViewUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
           <asp:GridView ID="tableUser" runat="server" ></asp:GridView>
    </div>
        <br />
    <div>
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Block User?</asp:LinkButton>
        &emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&ensp;
        <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click" >unBlock User?</asp:LinkButton>
        &emsp;&emsp;&emsp;&emsp;&emsp;&emsp;
        <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click" >Change User Role?</asp:LinkButton>
    </div>
        <br />
    <div>
        <asp:Label ID="Label1" runat="server" Text="User Id: "></asp:Label>
        <asp:TextBox ID="blockTxt" runat="server"></asp:TextBox>

        <asp:Label ID="Label2" runat="server" Text="User Id: "></asp:Label>
        <asp:TextBox ID="unblockTxt" runat="server"></asp:TextBox>

        <asp:Label ID="Label3" runat="server" Text="User Id: "></asp:Label>
        <asp:TextBox ID="changeRoleTxt" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="Button1" runat="server" Text="Blacklist User" OnClick="Button1_Click" />
        
        <asp:Button ID="Button2" runat="server" Text="unBlacklist User" OnClick="Button2_Click"/>

        <asp:Button ID="Button3" runat="server" Text="Change Role" OnClick="Button3_Click"/>
    </div>
    </form>
    <br />

    <div>
        <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
    </div>
</body>
</html>
