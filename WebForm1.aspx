<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:RadioButton ID="RadioButton1" runat="server" OnCheckedChanged="RadioButton1_CheckedChanged" Text="CCAPI" />
        <asp:RadioButton ID="RadioButton2" runat="server" OnCheckedChanged="RadioButton2_CheckedChanged" Text="TMAPI" />
        <p>
            <asp:TextBox ID="TextBox1" runat="server">192.168.1.1</asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Conect" />
        </p>
        <p>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Attach" />
        </p>
        <p>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Send" />
        </p>
        <p>
            <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox1_CheckedChanged" Text="Non Host" />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="On" />
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Off" />
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Connection Status"></asp:Label>
        </p>
    </form>
</body>
</html>
