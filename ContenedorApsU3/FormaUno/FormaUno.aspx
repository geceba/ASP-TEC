<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormaUno.aspx.cs" Inherits="FormaUno.FormaUno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
 <style>
    .espacio
    {
        margin-left: 50px;
    }
    
</style>
</head>

<body>
    <form id="form1" runat="server">
    <div>
       <asp:Label ID="Label1" runat="server" Text="Dato1"></asp:Label>
        <asp:TextBox ID="Data1" runat="server" CssClass="espacio" OnTextChanged="Data1_TextChanged"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Dato2"></asp:Label>
        <asp:TextBox ID="Data2" runat="server" CssClass="espacio" OnTextChanged="Data2_TextChanged"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Dato3"></asp:Label>
        <input id="Dato3" runat="server" type="text" Class="espacio">
        <br />
        <asp:Button ID="BtnCalcular" runat="server" Text="Calcular" OnClick="BtnCalcular_Click" />
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="La Suma es:"></asp:Label>
        <asp:Label ID="resultado" runat="server" CssClass="espacio"></asp:Label>
        <br />
    </div>
    </form>
</body>
</html>
