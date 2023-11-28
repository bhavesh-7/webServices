<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="pract3._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox runat="server" ID="txttemp" ></asp:TextBox>
            <asp:Button runat="server" ID="ftc" OnClick="ftc_Click" Text="F to C"/>
            <asp:Button runat="server" ID="ctf" OnClick="ctf_Click" Text="C to F"/>
            <asp:Label runat="server" ID="result"></asp:Label>
        </div>
    </form>
</body>
</html>
