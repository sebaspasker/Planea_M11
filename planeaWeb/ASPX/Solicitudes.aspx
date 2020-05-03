<%@ Page Title="" Language="C#" MasterPageFile="~/MASTER/Default2.Master" AutoEventWireup="true" CodeBehind="Solicitudes.aspx.cs" Inherits="planeaWeb.Solicitudes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../CSS/Registro.css" rel="stylesheet"/>
    <div class="Registrarse_css1"> 
        <p style="text-align: left; margin-top: 20px">
            &nbsp;&nbsp;&nbsp;&nbsp;
            Solicitudes <br />
        </p>
        <asp:CheckBoxList ID="CheckBoxListSolicitudes" runat="server" CssClass="label_lista" style="text-align: left"></asp:CheckBoxList>
        <br />
        <asp:Button ID="ButtonAgregar" runat="server" Text="Agregar" OnClick="FunctionAgregarSolicitud" />
        <br />
        <br />
        <asp:Label ID="ErrorSolicitud" runat="server" Text=""></asp:Label>
        <br />
        <br />
    </div>
</asp:Content>
