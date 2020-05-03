<%@ Page Title="" Language="C#" MasterPageFile="~/MASTER/Default1.Master" AutoEventWireup="true" CodeBehind="BuscarPlan.aspx.cs" Inherits="planeaWeb.BuscarPlan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../CSS/Registro.css" rel="stylesheet"/>
    <div class="Registrarse_css1" style="margin-top: 20px">
        <p style="text-align:left"> <br />
        </p>
        <p >&nbsp;&nbsp; Nombre del plan:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Nombre" runat="server"></asp:TextBox> &nbsp;&nbsp;
            <asp:Button ID="ButtonBuscar" runat="server" Text="Buscar" OnClick="ButtonBuscar2"/>
            <br/>
            &nbsp; <br />
        </p>
        <p class="label_lista">
            <asp:Label id="BuscaPlanR" runat="server"/><br />
        </p>
        <p>
            &nbsp;
        </p>
    </div>
</asp:Content>
