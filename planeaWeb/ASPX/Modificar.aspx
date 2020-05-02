<%@ Page Title="" Language="C#" MasterPageFile="~/MASTER/Default2.Master" AutoEventWireup="true" CodeBehind="Modificar.aspx.cs" Inherits="planeaWeb.Modificar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../CSS/Login.css" rel="stylesheet"/>
    <div class="Modificar_css1">
        <h5>&nbsp;&nbsp;</h5>
        <h5 style="text-align: left; margin-left: 40px;">&nbsp;Modificar perfil: </h5>
        <p style="margin-left: 40px">Nombre: <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label> </p>
        <p style="margin-left: 40px">Apellidos: <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></p>
        <p style="margin-left: 40px">Nombre de Usuario: <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></p>
        <p style="margin-left: 40px">Edad: <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label></p>
        <p style="margin-left: 40px">Preferencia: <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label></p>
        <p style="margin-left: 40px">Ciudad: <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label></p>
        <p style="margin-left: 40px">Cambiar: <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label></p>
        <p style="margin-left: 40px">
            <asp:DropDownList ID="myDropDownList" runat="server" DataTextField="FullName" DataValueField="ID" OnLoad="myDropDownList_Load" OnSelectedIndexChanged="myDropDownList_SelectedIndexChanged" Width="116px" >
                <asp:ListItem>Nombre</asp:ListItem>
                <asp:ListItem>Contraseña</asp:ListItem>
                <asp:ListItem>Apellido</asp:ListItem>
                <asp:ListItem>NombreUsuario</asp:ListItem>
                <asp:ListItem>Edad</asp:ListItem>
                <asp:ListItem>Preferencia</asp:ListItem>
                <asp:ListItem>Ciudad</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p style="margin-left: 40px">
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <p style="margin-left: 40px">
            &nbsp;<asp:Button ID="Button9" runat="server" OnClick="Button1_Click" Text="Cambiar" style="background:#97CBDC"/>
        </p>
        <p><br /></p>
    </div>
</asp:Content>