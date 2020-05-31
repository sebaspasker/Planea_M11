<%@ Page Title="" Language="C#" MasterPageFile="~/MASTER/Default1.Master" AutoEventWireup="true" CodeBehind="BuscarPlan.aspx.cs" Inherits="planeaWeb.BuscarPlan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../CSS/Registro.css" rel="stylesheet"/>
    <div class="Registrarse_css1" style="margin-top: 20px">
        <p style="text-align:left"> <br />
        </p>
        <p >&nbsp;&nbsp; Nombre del plan:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Nombre" runat="server" ></asp:TextBox> &nbsp;&nbsp;
            <asp:Button ID="ButtonBuscar" runat="server" Text="Buscar" OnClick="ButtonBuscar2" style="height: 26px"/>
            <br/>
            &nbsp; <br />
        </p>
        <p>
            <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" HorizontalAlign="Center">
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
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            &nbsp;<br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/ASPX/Webscrap.aspx" >¿No sale el plan que te esperabas? Aporta tu granito de arena</asp:HyperLink>
        </p>
    </div>
</asp:Content>
