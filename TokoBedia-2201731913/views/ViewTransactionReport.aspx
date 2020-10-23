﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewTransactionReport.aspx.cs" Inherits="TokoBedia_2201731913.views.ViewTransactionReport" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" Namespace="CrystalDecisions.Web" TagPrefix="CR" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="BackButton" runat="server" Text="Back To Home" OnClick="BackButton_Click" />
    </div>
    <div>
        <CR:CrystalReportViewer ID="CrystalReportViewer" runat="server" AutoDataBind="true" />
    </div>
    </form>
</body>
</html>
