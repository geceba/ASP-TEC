<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LanzaDado.aspx.cs" Inherits="LanzaDado.LanzaDado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblInfo" runat="server" Text=""></asp:Label>
        <br />
    
    </div>
        <asp:Button ID="btnLanzar" runat="server" OnClick="btnLanzar_Click" Text="Lanzar" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnDesplegar" runat="server" OnClick="btnDesplegar_Click" Text="Desplegar" />
        <br />
        <br />
        <asp:Label ID="lblProm" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
