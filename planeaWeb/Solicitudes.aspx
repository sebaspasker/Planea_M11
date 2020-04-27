<%@ Page Title="" Language="C#" MasterPageFile="~/Default2.Master" AutoEventWireup="true" CodeBehind="Solicitudes.aspx.cs" Inherits="planeaWeb.Solicitudes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="Registro.css" rel="stylesheet"/>
    <div class="Registrarse_css1"> 
        <p style="text-align: left">
            &nbsp;&nbsp;&nbsp;&nbsp;
            Solicitudes <br />
        </p>
        <asp:CheckBoxList ID="CheckBoxListSolicitudes" runat="server"></asp:CheckBoxList>
    </div>
</asp:Content>
