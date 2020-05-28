<%@ Page Title="" Language="C#" MasterPageFile="~/MASTER/Default2.Master" AutoEventWireup="true" CodeBehind="Modificar.aspx.cs" Inherits="planeaWeb.Modificar" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../CSS/Registro.css" rel="stylesheet"/>
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <div class="Registrarse_css1">
        <h5>&nbsp;&nbsp;</h5>
        <h5 style="text-align: left; margin-left: 40px;">&nbsp;Modificar perfil: </h5>
        <p style="margin-left: 40px">Nombre:</p>
        <p style="margin-left: 40px"> <asp:Label ID="Label1" runat="server" Text=""></asp:Label> </p>
        <p style="margin-left: 40px">&nbsp;</p>
        <p style="margin-left: 40px">Apellidos: </p>
        <p style="margin-left: 40px"> <asp:Label ID="Label2" runat="server" Text=""></asp:Label></p>
        <p style="margin-left: 40px">&nbsp;</p>
        <p style="margin-left: 40px">Nombre de Usuario:</p>
        <p style="margin-left: 40px">&nbsp;<asp:Label ID="Label3" runat="server" Text=""></asp:Label></p>
        <p style="margin-left: 40px">&nbsp;</p>
        <p style="margin-left: 40px">Edad: </p>
        <p style="margin-left: 40px"> <asp:Label ID="Label4" runat="server" Text=""></asp:Label></p>
        <p style="margin-left: 40px">&nbsp;</p>
        <p style="margin-left: 40px">Preferencia: </p>
        <p style="margin-left: 40px"> <asp:Label ID="Label5" runat="server" Text=""></asp:Label></p>
        <p style="margin-left: 40px">&nbsp;</p>
        <p style="margin-left: 40px">Ciudad: </p>
        <p style="margin-left: 40px"> <asp:Label ID="Label6" runat="server" Text=""></asp:Label></p>
        <p style="margin-left: 40px">&nbsp;</p>
        <p style="margin-left: 40px">
            <asp:DropDownList ID="DropDownListModificar" runat="server" DataTextField="FullName" DataValueField="IDModificar" Width="116px" >
                <asp:ListItem>Nombre</asp:ListItem>
                <asp:ListItem>Contraseña</asp:ListItem>
                <asp:ListItem>Apellidos</asp:ListItem>
                <asp:ListItem>Edad</asp:ListItem>
                <asp:ListItem>Preferencia</asp:ListItem>
                <asp:ListItem>Ciudad</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p style="margin-left: 40px">
            &nbsp;</p>
        <p style="margin-left: 40px">
        <asp:TextBox ID="NuevoValorModificar" runat="server"></asp:TextBox>
        <p style="margin-left: 40px">
            &nbsp;<p style="margin-left: 40px">
            &nbsp;<asp:Button ID="ButtonModificar" runat="server" OnClick="FunctionModificar" Text="Cambiar" style="background:#97CBDC"/>
        </p>
        <p style="margin-left: 40px">
            &nbsp;</p>
        <p style="margin-left: 40px">
            <asp:Button ID="ButtonEliminarM" runat="server" OnClick="Eliminar" Text="Eliminar Usuario" BackColor="Red" />
            <ajaxToolkit:ConfirmButtonExtender ID="ConfirmButtonExtender1" runat="server" ConfirmText="Seguro que deseas eliminar tu perfil?" Enabled="true" TargetControlID="ButtonEliminarM"/>
        </p>
        <p style="margin-left: 40px">
            <br />
        </p>
        <p style="margin-left: 40px; color: #ffffff"><asp:Label runat="server" ID="ErrorModificar" /></p>
    </div>
</asp:Content>