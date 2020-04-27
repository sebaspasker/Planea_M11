<%@ Page Title="" Language="C#" MasterPageFile="~/Default1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="planeaWeb.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="Login.css" rel="stylesheet"/>
    <div class="Loguearse_css1">
        <h5>&nbsp;&nbsp;</h5>
        <h5 style="text-align: left; margin-left: 40px;">&nbsp;Acceder: </h5>
        <p style="margin-left: 40px">Usuario: </p>
        <p style="margin-left: 40px">
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p style="margin-left: 40px">Contraseña:</p>
        <p style="margin-left: 40px">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <p style="margin-left: 40px">
            &nbsp;<asp:Button ID="Button9" runat="server" OnClick="Button1_Click" Text="Acceder" style="background:#97CBDC"/>
        </p>
        <p><br /></p>
    </div>
</asp:Content>