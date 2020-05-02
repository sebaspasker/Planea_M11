<%@ Page Title="" Language="C#" MasterPageFile="~/MASTER/Default1.Master" AutoEventWireup="true" CodeBehind="BuscarUsuario.aspx.cs" Inherits="planeaWeb.BuscarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../CSS/Registro.css" rel="stylesheet"/>
    <div class="Registrarse_css1" style="margin-top: 20px">
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="nombre" runat="server"></asp:TextBox> 
            &nbsp;&nbsp; 
            <asp:Button ID="ButtonBuscarID" OnClick="ButtonBuscarUsuario" runat="server" Text="Buscar" />
            <br/>
            &nbsp; <br />
        </p>
        <p class="label_lista">
            <asp:Label id="BuscaUsuarioR" runat="server" />
        </p>
        <br />
    </div>
</asp:Content>
