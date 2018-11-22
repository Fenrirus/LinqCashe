<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="LinqCashe.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <div style="font-family:Arial">
<table border="1">
    <tr>
        <td>
            <b>Account Number</b>
        </td>
        <td>
            <asp:Label ID="lblAccountNumber" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <b>Account Name</b>
        </td>
        <td>
            <asp:Label ID="lblAccountName" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <b>Account Balance</b>
        </td>
        <td>
            <asp:Label ID="lblAccountBalance" runat="server"></asp:Label>
        </td>
    </tr>
</table>
<br />
<asp:Button ID="btnDeposit" runat="server" Text="Deposit $500"
    onclick="btnDeposit_Click" />
</div>
        </div>
    </form>
</body>
</html>
