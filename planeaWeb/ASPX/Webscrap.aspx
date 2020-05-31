<%@ Page Title="" Language="C#" MasterPageFile="~/MASTER/Default1.Master" AutoEventWireup="true" CodeBehind="Webscrap.aspx.cs" Inherits="planeaWeb.ASPX.Webscrap" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../CSS/Registro.css" rel="stylesheet"/>
    <div class="Registrarse_css1" style="margin-top: 20px">
        
        <br />
        Añade tus planes<br />
        <br />
        Categoria<br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        Ciudad<br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Añade" />
        <br />
        <br />
        
    </div>
</asp:Content>
