<%@ Page Title="" Language="C#" MasterPageFile="~/MASTER/Default2.Master" AutoEventWireup="true" CodeBehind="Favoritos.aspx.cs" Inherits="planeaWeb.Favoritos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../CSS/Registro.css" rel="stylesheet"/>
    <div class="Registrarse_css1">
        <p>
            <br />Usuarios favoritos de <asp:Label ID="nombre_usuario" runat="server"/><br />&nbsp<br />
        </p>
        <p>
            <asp:Label ID="lista_favoritos" runat="server"/>
        </p>
    </div>
</asp:Content>
