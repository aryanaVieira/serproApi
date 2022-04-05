<%@ Page Language="C#" Async="True" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>
'
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    </head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:GridView ID="dgvDados" runat="server" ></asp:GridView>
            <asp:TextBox ID="TextBox1" runat="server" Height="269px" TextMode="MultiLine" Width="896px" Enabled="False"></asp:TextBox>


            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="API SERPRO" />
            </div>
    </form>
</body>
</html>
