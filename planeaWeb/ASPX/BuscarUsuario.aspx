<%@ Page Title="" Language="C#" MasterPageFile="~/MASTER/Default1.Master" AutoEventWireup="true" CodeBehind="BuscarUsuario.aspx.cs" Inherits="planeaWeb.BuscarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../CSS/Registro.css" rel="stylesheet"/>
    <div class="Registrarse_css1">
        <p style="text-align:left"> <br />
        </p>
        <p style="text-align:left">&nbsp;&nbsp; Nombre:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="nombre" runat="server"></asp:TextBox> <br/>
            &nbsp; <br />
        </p>
        <asp:Label id="BuscaUsuarioR" runat="server"/>
    </div>
</asp:Content>
