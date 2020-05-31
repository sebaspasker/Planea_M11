<%@ Page Title="" Language="C#" MasterPageFile="~/MASTER/Default1.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="planeaWeb.Registro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../CSS/Registro.css" rel="stylesheet"/>
    <link href="../CSS/Estilo_Default1.css" rel="stylesheet"/>
    <div class="Registrarse_css1">
        <h5>&nbsp;&nbsp;</h5>
        <h5 style="text-align: left; margin-left: 40px;">&nbsp;Regístrate: </h5>
        <p style="margin-left: 40px">Nombre: </p>
        <p style="margin-left: 40px">
            <asp:TextBox ID="TextNombre" runat="server"></asp:TextBox>
        </p>
        <p style="margin-left: 40px">
            &nbsp;</p>
        <p style="margin-left: 40px">Apellidos:</p>
        <p style="margin-left: 40px">
            <asp:TextBox ID="TextApellidos" runat="server"></asp:TextBox>
            &nbsp;</p>
        <p style="margin-left: 40px">
            &nbsp;</p>
        <p style="margin-left: 40px">Nombre de usuario:</p>
        <p style="margin-left: 40px">
            <asp:TextBox ID="TextNombreUsuario" runat="server" ></asp:TextBox>
        </p>
        <p style="margin-left: 40px">
            &nbsp;</p>
        <p style="margin-left: 40px">Ciudad:</p>
        <p style="margin-left: 40px">
            <asp:TextBox ID="TextCiudad" runat="server"></asp:TextBox>
        </p>
        <p style="margin-left: 40px">
            &nbsp;</p>
        <p style="margin-left: 40px">Email:</p>
        <p style="margin-left: 40px">
            <asp:TextBox ID="TextEmail" runat="server" ></asp:TextBox>
        </p>
        <p style="margin-left: 40px">
            &nbsp;</p>
        <p style="margin-left: 40px">Edad:</p>
        <p style="margin-left: 40px">
            <asp:TextBox ID="TextEdad" runat="server"></asp:TextBox>
        </p>
        <p style="margin-left: 40px">
            &nbsp;</p>
        <p style="margin-left: 40px">Contraseña:</p>
        <p style="margin-left: 40px">
            <asp:TextBox ID="TextPasswd" TextMode="Password" runat="server"></asp:TextBox>
        </p>
        <p style="margin-left: 40px">
            &nbsp;</p>
        <p style="margin-left: 40px">Preferencia:</p>
        <p style="margin-left: 40px">
            <asp:TextBox ID="TextPreferencia" runat="server" ></asp:TextBox>
        </p>
        <p style="margin-left: 40px">
            &nbsp;</p>
        <p style="margin-left: 40px">
            &nbsp;</p>
        <p style="margin-left: 40px">
            &nbsp;<asp:Button ID="RegistrarseButton2" runat="server" OnClick="RegistrarseFunction" Text="Registrarse" style="background:#97CBDC"/>
        </p>
        <p style="margin-left: 40px">
            &nbsp;</p>
        <p style="margin-left: 40px">
            <asp:Label ID="ErrorRegistro" runat="server" Text=""></asp:Label>
        </p>
        <p><br /></p>
    </div>
</asp:Content>
