<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="homepage.aspx.cs" Inherits="ctftcConverter.homepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            TEMP CALC<br />
            <br />
            <asp:TextBox AutoPostBack="true" ID="tempIn" runat="server"></asp:TextBox>
            <asp:Button ID="tc" runat="server" OnClick="ttc" Text="Fahrenheit To Celcius" />
            <asp:Button ID="tf" runat="server" OnClick="ttf" Text="Celcius To Fahrenheit" />
            <br />
            Result =
            <asp:Label ID="outputTemp" runat="server"></asp:Label>
        </div>
        <div>
            <br />
            ARTHMETIC OP<br />
            <br />
            <asp:TextBox AutoPostBack="true" ID="num1in" runat="server"></asp:TextBox>
            <asp:TextBox AutoPostBack="true" ID="num2in" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="add" runat="server" OnClick="calc" Text="ADD" OnClientClick="add" />
            <asp:Button ID="sub" runat="server" OnClick="calc" Text="SUB" OnClientClick="sub" />
            <asp:Button ID="mul" runat="server" OnClick="calc" Text="MUL" OnClientClick="mul" />
            <asp:Button ID="div" runat="server" OnClick="calc" Text="DIV" OnClientClick="div" />
            <asp:Button ID="mod" runat="server" OnClick="calc" Text="MOD" OnClientClick="mod" />
            <br />
            <br />
            ANS =
            <asp:Label ID="outArth" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
