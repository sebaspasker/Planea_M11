<%@ Page Title="" Language="C#" MasterPageFile="~/MASTER/Default1.Master" AutoEventWireup="true" CodeBehind="BuscarUsuario.aspx.cs" Inherits="planeaWeb.BuscarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../CSS/Registro.css" rel="stylesheet"/>
    <div class="Registrarse_css1" style="margin-top: 20px">
        <p>
            &nbsp;</p>
        <p>
            Nombre del usuario:
            <asp:TextBox ID="nombre" runat="server"></asp:TextBox> 
            &nbsp;&nbsp; 
            <asp:Button ID="ButtonBuscarID" OnClick="ButtonBuscarUsuario" runat="server" Text="Buscar" />
            <br/>
            &nbsp; <br />
        </p>
        <p class="label_lista">
            <asp:Label id="BuscaUsuarioR" runat="server" />
        </p>
        <p style="margin-left: 360px">
        <br />
        <asp:GridView ID="GridViewBusca" runat="server" HorizontalAlign="Center" CellPadding="4" ForeColor="#333333" GridLines="None" >
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        </p>
        <br />
    </div>
</asp:Content>
