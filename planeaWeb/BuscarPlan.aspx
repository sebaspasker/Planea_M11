<%@ Page Title="" Language="C#" MasterPageFile="~/Default1.Master" AutoEventWireup="true" CodeBehind="BuscarPlan.aspx.cs" Inherits="planeaWeb.BuscarPlan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="Registro.css" rel="stylesheet"/>
    <div class="Registrarse_css1">
        <p style="text-align:left"> <br />
        </p>
        <p style="text-align:left">&nbsp;&nbsp; Nombre del plan:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="nombre_plan" runat="server"></asp:TextBox> <br/>
            &nbsp; <br />
        </p>
        <asp:Label id="BuscaPlanR" runat="server"/>
    </div>
</asp:Content>
