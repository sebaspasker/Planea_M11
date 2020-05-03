<%@ Page Title="" Language="C#" MasterPageFile="~/MASTER/Default1.Master" AutoEventWireup="true" CodeBehind="BuscarPlan.aspx.cs" Inherits="planeaWeb.BuscarPlan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../CSS/Registro.css" rel="stylesheet"/>
    <div class="Registrarse_css1">
        <p style="text-align:left"> <br />
        </p>
        <p style="text-align:left">&nbsp;&nbsp; Nombre del plan:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Nombre" runat="server"></asp:TextBox> &nbsp;&nbsp;
            <asp:Button ID="ButtonBuscar" runat="server" Text="Buscar" />
            <br/>
            &nbsp; <br />
        </p>
        <asp:Label id="BuscaPlanR" runat="server"/>
    </div>
</asp:Content>
