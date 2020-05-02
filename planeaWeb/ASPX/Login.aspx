<%@ Page Title="" Language="C#" MasterPageFile="~/MASTER/Default1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="planeaWeb.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../CSS/Registro.css" rel="stylesheet"/>
    <div class="Registrarse_css1">
        <h5>&nbsp;&nbsp;</h5>
        <h5 style="text-align: left; margin-left: 40px;">&nbsp;Acceder: </h5>
        <p style="margin-left: 40px">Usuario: </p>
        <p style="margin-left: 40px">
            <asp:TextBox ID="NombreUsuario" runat="server"></asp:TextBox>
        </p>
        <p style="margin-left: 40px">Contraseña:</p>
        <p style="margin-left: 40px">
            <asp:TextBox ID="Password" runat="server"></asp:TextBox>
        <p style="margin-left: 40px">
            &nbsp;<asp:Button ID="Button9" runat="server" OnClick="LoginFunction" Text="Acceder" style="background:#97CBDC"/>
        </p>
        <p style="margin-left: 40px">
            <asp:HyperLink ID="Registrarse2ID" NavigateUrl="~/ASPX/Registro.aspx" runat="server" style="color: #ffffff; height: 2px; font-size: 16px">Registrarse</asp:HyperLink>
        </p>
        <p style="margin-left: 40px">
            <asp:Label ID="ErrorLogin" runat="server" Text="" style="color: #ffffff"></asp:Label> <br />
        </p>
    </div>
</asp:Content>