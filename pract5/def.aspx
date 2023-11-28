<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="def.aspx.cs" Inherits="pract4.def" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            NUM 1 =
            <asp:TextBox ID="txtnum1" runat="server"></asp:TextBox>
            <br />
            NUM 2 = <asp:TextBox ID="txtnum2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="add" runat="server" Text="add" OnClick="add_Click"/>
            <asp:Button ID="sub" runat="server" Text="sub" OnClick="sub_Click" />
            <br />
            RESULT = 
            <asp:Label runat="server" ID="result"></asp:Label>

        </div>
    </form>
</body>
</html>
