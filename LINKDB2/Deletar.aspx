<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Deletar.aspx.cs" Inherits="LINKDB2.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="DELETAR"></asp:Label>
            <br />
            (consulte o item para depois deletar)<br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Listar" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Consulta Individual" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Text="Inserir" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button10" runat="server" OnClick="Button10_Click" Text="Alterar" />
            <br />
            <br />
            <br />
            &nbsp;<asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Consultar Cidade" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="DELETAR POR  ID CIDADE" />
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            &nbsp;<asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Consulta por Código País" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="DELETAR POR CÓDIGO PAÍS" />
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" MaxLength="3"></asp:TextBox>
            <br />
            <br />
            &nbsp;<asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="Consulta Língua" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button5" runat="server" Text="DELETAR POR LÍNGUA " OnClick="Button5_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
