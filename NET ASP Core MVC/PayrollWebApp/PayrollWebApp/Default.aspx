<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PayrollWebApp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="./Styles/site.css" rel="stylesheet" type="text/css" />
    <title>Payroll Calculation</title>
</head>
<body style="flex-direction: column;">
    <div>
        <h1>Payroll Calculations</h1>
        <img src="./Images/money.jpg"></img>
    </div>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Hours Worked:</td>
                    <td><asp:TextBox ID="txtHours" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Hourly Rate:</td>
                    <td><asp:TextBox ID="txtRate" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblMessage" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td><asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click"/></td>
                    <td><asp:Button ID="btnReset" runat="server" Text="Reset" OnClick="btnReset_Click"/></td>
                </tr>
                <tr>
                    <td>Pay amount:</td>
                    <td><asp:Label ID="lblPay" runat="server" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
