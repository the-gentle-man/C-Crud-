<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inserir.aspx.cs" Inherits="LINKDB2.Inserir" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            INSERIR<br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Consulta individual" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Listar" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Deletar" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Alterar" />
            <br />
            <br />
            -------------------------------------------------------------------------------------------------------------------------------------<br />
            <br />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Inserir cidade " />
&nbsp;&nbsp;&nbsp;NAME:&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp; COUNTRYCODE:
            <asp:TextBox ID="TextBox2" runat="server" MaxLength="3"></asp:TextBox>
&nbsp;&nbsp;
            <br />
            <br />
&nbsp;DISTRICT: <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; POPULATION:&nbsp;
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;<br />
            <br />
            <br />
            -------------------------------------------------------------------------------------------------------------------------------------<br />
            <br />
            <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="inserir Língua" />
            &nbsp;&nbsp;&nbsp; (Como a Primary Key dessa tabela contém um elemento da tabela Coutry é preciso colocar o mesmo CountryCode)<br />
            <br />
            COUNTRYCODE:&nbsp; <asp:TextBox ID="TextBox6" runat="server" MaxLength="3"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; LANGUAGE:&nbsp;
            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <br />
            <br />
&nbsp; IS OFFICIAL:
            <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
&nbsp;(T ou F)&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; PERCENTAGE:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            -------------------------------------------------------------------------------------------------------------------------------------<br />
            <br />
            <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Inserir País" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <br />
&nbsp;Code:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox10" runat="server" MaxLength="3"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Name:&nbsp;&nbsp;
            <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Continent:
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>Asia</asp:ListItem>
                <asp:ListItem>Europe</asp:ListItem>
                <asp:ListItem>North America</asp:ListItem>
                <asp:ListItem>Africa</asp:ListItem>
                <asp:ListItem>Oceania</asp:ListItem>
                <asp:ListItem>Antarctica</asp:ListItem>
                <asp:ListItem>South America</asp:ListItem>
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Region&nbsp;
            <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
&nbsp;SurfaceArea:&nbsp;
            <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; IndepYear&nbsp;
            <asp:TextBox ID="TextBox15" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Population&nbsp;
            <asp:TextBox ID="TextBox16" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; LifeExpectancy&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox17" runat="server"></asp:TextBox>
            <br />
            <br />
&nbsp; GNP&nbsp;
            <asp:TextBox ID="TextBox18" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; GNPOld&nbsp;
            <asp:TextBox ID="TextBox19" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; LocalName<asp:TextBox ID="TextBox20" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; GovernmentForm&nbsp;
            <asp:TextBox ID="TextBox21" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
&nbsp; HeadOfState
            <asp:TextBox ID="TextBox22" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Capital&nbsp;
            <asp:TextBox ID="TextBox23" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Code2&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox24" runat="server"></asp:TextBox>
        </div>
    </form>


</body>
</html>
