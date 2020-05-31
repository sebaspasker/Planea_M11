<%@ Page Title="" Language="C#" MasterPageFile="~/MASTER/Default1.Master" AutoEventWireup="true" CodeBehind="Favoritos.aspx.cs" Inherits="planeaWeb.Favoritos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../CSS/Registro.css" rel="stylesheet"/>
    <div class="Registrarse_css1" style="margin-top: 20px">
        <p>
            <br />Usuarios favoritos de <asp:Label ID="nombre_usuario" runat="server"/><br />&nbsp<br />
        </p>
        <p class="label_lista">
            <asp:Label ID="lista_favoritos" runat="server"/>
        </p>
        <p>
            &nbsp;
        </p>
        <p>
            &nbsp;</p>
    </div>
</asp:Content>
