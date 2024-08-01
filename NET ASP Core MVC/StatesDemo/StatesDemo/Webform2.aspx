<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Webform2.aspx.cs" Inherits="StatesDemo.Webform2" %>

<!DOCTYPE html>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>I am web form 2</h1>
    <form id="form1" runat="server">
        <div>
            <p>
                <asp:Button ID="btnClick" runat="server" Text="Click Me" OnClick="btnClick_Click" />
            </p>
            <p>
                Counter: <asp:Label ID="lblCount" runat="server" Text=""></asp:Label>
            </p>
        </div>
        <asp:Button ID="btnGo" runat="server" Text="Go to page 1" PostBackUrl="~/Webform1.aspx" />
    </form>
</body>
</html>
