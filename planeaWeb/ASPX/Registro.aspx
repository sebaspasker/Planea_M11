<%@ Page Title="" Language="C#" MasterPageFile="~/MASTER/Default1.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="planeaWeb.Registro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../CSS/Registro.css" rel="stylesheet"/>
    <link href="../CSS/Estilo_Default1.css" rel="stylesheet"/>
    <div class="Registrarse_css1">
        <h5>&nbsp;&nbsp;</h5>
        <h5 style="text-align: left; margin-left: 40px;">&nbsp;Regístrate: </h5>
        <p style="margin-left: 40px">Nombre: </p>
        <p style="margin-left: 40px">
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p style="margin-left: 40px">Apellidos:</p>
        <p style="margin-left: 40px">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p style="margin-left: 40px">Nombre de usuario:</p>
        <p style="margin-left: 40px">
            <asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
        </p>
        <p style="margin-left: 40px">Ciudad:</p>
        <p style="margin-left: 40px">
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </p>
        <p style="margin-left: 40px">Email:</p>
        <p style="margin-left: 40px">
            <asp:TextBox ID="TextBox5" runat="server" OnTextChanged="TextBox5_TextChanged"></asp:TextBox>
        </p>
        <p style="margin-left: 40px">Edad:</p>
        <p style="margin-left: 40px">
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        </p>
        <p style="margin-left: 40px">Contraseña:</p>
        <p style="margin-left: 40px">
            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        </p>
        <p style="margin-left: 40px">Preferencia:</p>
        <p style="margin-left: 40px">
            <asp:TextBox ID="TextBox8" runat="server" OnTextChanged="TextBox8_TextChanged"></asp:TextBox>
        </p>
        <p style="margin-left: 40px">
            &nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Registrarse" style="background:#97CBDC"/>
        </p>
        <p><br /></p>
    </div>
</asp:Content>
