﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CompanyWebClient.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table style="font-family:'Times New Roman', Times, serif">
        <tr>
            <td>
                <asp:Button ID="Button1" runat="server" Text="PublicInfo" OnClick="Button1_Click" /></td>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Button2" runat="server" Text="PrivateInfo" OnClick="Button2_Click" />
            </td>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
