﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MASTER/Default2.Master" AutoEventWireup="true" CodeBehind="Solicitudes.aspx.cs" Inherits="planeaWeb.Solicitudes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../CSS/Registro.css" rel="stylesheet"/>
    <div class="Registrarse_css1"> 
        <p style="text-align: left; margin-top: 20px">
            &nbsp;&nbsp;&nbsp;&nbsp;
            Solicitudes <br />
        </p>
        <asp:CheckBoxList ID="CheckBoxListSolicitudes" runat="server" CssClass="label_lista" style="text-align: left"></asp:CheckBoxList>
        <br />
        <asp:GridView ID="GridView1" runat="server" HorizontalAlign="Center" CellPadding="4" ForeColor="#333333" GridLines="None">
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
        <br />
        <asp:Button ID="ButtonAgregar" runat="server" Text="Agregar" OnClick="FunctionAgregarSolicitud" />
        <br />
        <br />
        <asp:Label ID="ErrorSolicitud" runat="server" Text=""></asp:Label>
        <br />
        <br />
    </div>
</asp:Content>
