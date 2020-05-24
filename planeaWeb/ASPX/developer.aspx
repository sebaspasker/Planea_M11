<%@ Page Title="" Language="C#" MasterPageFile="~/MASTER/Default1.Master" AutoEventWireup="true" CodeBehind="developer.aspx.cs" Inherits="planeaWeb.ASPX.developer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../CSS/Registro.css" rel="stylesheet" />
    <div class="Registrarse_css1" style="margin-top:20px;">
        <br />
        <p style="text-align:left; margin-left: 40px;">
            Usuarios 
        </p>
        <p style="text-align:left; margin-left: 40px;">
            &nbsp;</p>
        <p style="text-align:left; margin-left: 40px;">
            &nbsp;</p>
        <p style="text-align:left; margin-left: 40px;">
            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="id" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id" />
                    <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
                    <asp:BoundField DataField="apellidos" HeaderText="apellidos" SortExpression="apellidos" />
                    <asp:BoundField DataField="nombre_usuario" HeaderText="nombre_usuario" SortExpression="nombre_usuario" />
                    <asp:BoundField DataField="ciudad" HeaderText="ciudad" SortExpression="ciudad" />
                    <asp:BoundField DataField="preferencia" HeaderText="preferencia" SortExpression="preferencia" />
                    <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
                    <asp:BoundField DataField="edad" HeaderText="edad" SortExpression="edad" />
                    <asp:BoundField DataField="password" HeaderText="password" SortExpression="password" />
                </Columns>
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
            <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Parejas]"></asp:SqlDataSource>

        </p>
        <p style="text-align:left; margin-left: 40px;">
            &nbsp;</p>
        <p style="text-align:left; margin-left: 40px;">
            Planes</p>
        <p style="text-align:left; margin-left: 40px;">
            &nbsp;</p>
        <p style="text-align:left; margin-left: 40px;">
            <asp:GridView ID="GridView3" runat="server" DataSourceID="SqlDataSource3" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="id" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id" />
                    <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
                    <asp:BoundField DataField="precio" HeaderText="precio" SortExpression="precio" />
                    <asp:BoundField DataField="ciudad" HeaderText="ciudad" SortExpression="ciudad" />
                    <asp:BoundField DataField="categoria" HeaderText="categoria" SortExpression="categoria" />
                </Columns>
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
            <asp:SqlDataSource ID="SqlDataSource5" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Favoritos]"></asp:SqlDataSource>

        </p>
        <p style="text-align:left; margin-left: 40px;">
            &nbsp;</p>
        <p style="text-align:left; margin-left: 40px;">
            Parejas</p>
        <p style="text-align:left; margin-left: 40px;">
            &nbsp;</p>
        <asp:GridView ID="GridView1" runat="server" Width="360px" style="margin-left: 40px" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource4" AllowPaging="True" AllowSorting="True" CellPadding="4" ForeColor="#333333" GridLines="None" >
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="nombre_usuario_1" HeaderText="nombre_usuario_1" SortExpression="nombre_usuario_1" />
                <asp:BoundField DataField="nombre_usuario_2" HeaderText="nombre_usuario_2" SortExpression="nombre_usuario_2" />
                <asp:BoundField DataField="nombre_plan" HeaderText="nombre_plan" SortExpression="nombre_plan" />
                <asp:BoundField DataField="hora_inicio" HeaderText="hora_inicio" SortExpression="hora_inicio" />
                <asp:BoundField DataField="hora_fin" HeaderText="hora_fin" SortExpression="hora_fin" />
                <asp:BoundField DataField="dia" HeaderText="dia" SortExpression="dia" />
                <asp:BoundField DataField="aceptado" HeaderText="aceptado" SortExpression="aceptado" />
            </Columns>
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
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Usuarios]"></asp:SqlDataSource>
        </asp:GridView>

        <p style="text-align:left; margin-left:40px">
            Favoritos
        </p>
        <p style="text-align:left; margin-left:40px">
            &nbsp;</p>
        <asp:GridView ID="SqlDataSource2" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="id" DataSourceID="SqlDataSource5" ForeColor="#333333" GridLines="None" style="margin-left:40px">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="nombre_usuario" HeaderText="nombre_usuario" SortExpression="nombre_usuario" />
                <asp:BoundField DataField="nombre_usuario_favorito" HeaderText="nombre_usuario_favorito" SortExpression="nombre_usuario_favorito" />
            </Columns>
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
        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Planes]"></asp:SqlDataSource>
    </div>
</asp:Content>
