<%@ Page Title="" Language="C#" MasterPageFile="~/MASTER/Default1.Master" AutoEventWireup="true" CodeBehind="developer.aspx.cs" Inherits="planeaWeb.ASPX.developer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../CSS/Registro.css" rel="stylesheet" />
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <div class="Registrarse_css1" style="margin-top:20px;">
        <br />
        <p style="text-align:left; margin-left: 40px;">
            Usuarios 
        </p>
        <p style="text-align:left; margin-left: 40px;">
            nombre_usuario&nbsp;</p>
        <p style="text-align:left; margin-left: 40px;">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;</p>
        <p style="text-align:left; margin-left: 40px;">
            nombre</p>
        <p style="text-align:left; margin-left: 40px;">
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p style="text-align:left; margin-left: 40px;">
            apellidos</p>
        <p style="text-align:left; margin-left: 40px;">
            &nbsp;<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
&nbsp;</p>
        <p style="text-align:left; margin-left: 40px;">
            ciudad</p>
        <p style="text-align:left; margin-left: 40px;">
            <asp:TextBox ID="TextBox4" runat="server" ></asp:TextBox>
&nbsp;</p>
        <p style="text-align:left; margin-left: 40px;">
            preferencia</p>
        <p style="text-align:left; margin-left: 40px;">
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </p>
        <p style="text-align:left; margin-left: 40px;">
            email</p>
        <p style="text-align:left; margin-left: 40px;">
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        </p>
        <p style="text-align:left; margin-left: 40px;">
            edad</p>
        <p style="text-align:left; margin-left: 40px;">
            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        </p>
        <p style="text-align:left; margin-left: 40px;">
            password</p>
        <p style="text-align:left; margin-left: 40px;">
            <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
        </p>
        <p style="text-align:left; margin-left: 40px;">
            &nbsp;</p>
        <p style="text-align:left; margin-left: 40px;">
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </p>
        <p style="text-align:left; margin-left: 40px;">
            &nbsp;</p>
        <p style="text-align:left; margin-left: 40px;">
            <asp:Button ID="ButtonInsertar" runat="server" Text="Insertar" OnClick="ButtonInsertar_Click" />
            &nbsp;<asp:Button ID="ButtonEliminar" runat="server" Text="Eliminar" OnClick="ButtonBorrar_Click"/>
            &nbsp;</p>
        <p style="text-align:left; margin-left: 40px;">
            &nbsp;</p>
        <p style="text-align:left; margin-left: 40px;">
            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="id" DataSourceID="SqlDataSource4" ForeColor="#333333" GridLines="None">
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
            <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" SelectCommand="SELECT * FROM [Usuarios]"></asp:SqlDataSource>
        </p>
        <p style="text-align:left; margin-left: 40px;">
            &nbsp;</p>
        <p style="text-align:left; margin-left: 40px;">
            Planes</p>
        <p style="text-align:left; margin-left: 40px;">
            &nbsp;</p>
        <p style="text-align:left; margin-left: 40px;">
            Nombre</p>
        <p style="text-align:left; margin-left: 40px;">
            <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
        </p>
        <p style="text-align:left; margin-left: 40px;">
            Precio</p>
        <p style="text-align:left; margin-left: 40px;">
            <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
        </p>
        <p style="text-align:left; margin-left: 40px;">
            Ciudad</p>
        <p style="text-align:left; margin-left: 40px;">
            <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
        </p>
        <p style="text-align:left; margin-left: 40px;">
            Categoria</p>
        <p style="text-align:left; margin-left: 40px;">
            <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
        </p>
        <p style="text-align:left; margin-left: 40px;">
            &nbsp;</p>
        <p style="text-align:left; margin-left: 40px;">
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
        </p>
        <p style="text-align:left; margin-left: 40px;">
            &nbsp;</p>
        <p style="text-align:left; margin-left: 40px;">
            <asp:Button ID="ButtonInsertarPlan" runat="server" Text="Insertar" OnClick="ButtonInsertarPlan_Click" style="height: 26px" />
&nbsp;<asp:Button ID="ButtonEliminarPlan" runat="server" Text="Eliminar" OnClick="ButtonEliminarPlan_Click" />
        </p>
        <p style="text-align:left; margin-left: 40px;">
            &nbsp;</p>
        <p style="text-align:left; margin-left: 40px;">
            <asp:GridView ID="GridView3" runat="server" DataSourceID="SqlDataSource22" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="id" ForeColor="#333333" GridLines="None">
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
            <asp:SqlDataSource ID="SqlDataSource22" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" SelectCommand="SELECT * FROM [Planes]"></asp:SqlDataSource>

        </p>
        <p style="text-align:left; margin-left: 40px;">
            &nbsp;</p>
        <p style="text-align:left; margin-left: 40px;">
            Parejas</p>
        <p style="text-align:left; margin-left: 40px;">
            &nbsp;</p>
        <p style="text-align:left; margin-left: 40px;">
            Nombre Usuario 1</p>
        <p style="text-align:left; margin-left: 40px;">
            <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
        </p>
        <p style="text-align:left; margin-left: 40px;">
            Nombre Usuario 2</p>
        <p style="text-align:left; margin-left: 40px;">
            <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox>
        </p>
        <p style="text-align:left; margin-left: 40px;">
            Nombre Plan</p>
        <p style="text-align:left; margin-left: 40px;">
            &nbsp;<asp:TextBox ID="TextBox15" runat="server"></asp:TextBox>
        </p>
        <p style="text-align:left; margin-left: 40px;">
            Hora Inicio</p>
        <p style="text-align:left; margin-left: 40px;">
            <asp:TextBox ID="TextBox16" runat="server"></asp:TextBox>
        </p>
        <p style="text-align:left; margin-left: 40px;">
            Hora Fin</p>
        <p style="text-align:left; margin-left: 40px;">
            <asp:TextBox ID="TextBox17" runat="server"></asp:TextBox>
        </p>
        <p style="text-align:left; margin-left: 40px;">
            Aceptado</p>
        <p style="text-align:left; margin-left: 40px;">
            <asp:TextBox ID="TextBox18" runat="server"></asp:TextBox>
        </p>
        <p style="text-align:left; margin-left: 40px;">
            &nbsp;</p>
        <p style="text-align:left; margin-left: 40px;">
            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        </p>
        <p style="text-align:left; margin-left: 40px;">
            &nbsp;</p>
        <p style="text-align:left; margin-left: 40px;">
            <asp:Button ID="Button1" runat="server" Text="Insertar" OnClick="ButtonInsertarPareja" />
        &nbsp;<asp:Button ID="Button2" runat="server" Text="Borrar" OnClick="ButtonBorrarPareja" />
        </p>
        <p style="text-align:left; margin-left: 40px;">
            <asp:Label ID="Error_Pareja" runat="server" Text=""></asp:Label>
        </p>
        <asp:GridView ID="GridView1" runat="server" Width="360px" style="margin-left: 40px" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" AllowPaging="True" AllowSorting="True" CellPadding="4" ForeColor="#333333" GridLines="None" DataKeyNames="id" >
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
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True" SelectCommand="SELECT * FROM [Parejas]" ProviderName="System.Data.SqlClient"></asp:SqlDataSource>
        <br />
        <p style="text-align:left; margin-left:40px">
            Favoritos
        </p>
        <p style="text-align:left; margin-left:40px">
            nombre_usuario</p>
        <p style="text-align:left; margin-left:40px">
            <asp:TextBox ID="TextBox19" runat="server"></asp:TextBox>
        </p>
        <p style="text-align:left; margin-left:40px">
            nombre_usuario_favorito</p>
        <p style="text-align:left; margin-left:40px">
            <asp:TextBox ID="TextBox20" runat="server"></asp:TextBox>
        </p>
        <p style="text-align:left; margin-left:40px">
            <asp:Button ID="Button3" runat="server" OnClick="ButtonInsertarFav" Text="Insertar" />
&nbsp;<asp:Button ID="Button4" runat="server" OnClick="ButtonBorrarFav" Text="Borrar" />
        </p>
        <p style="text-align:left; margin-left:40px">
            <asp:Label ID="LabelErrorFav" runat="server" Text=""></asp:Label>
        </p>
        <asp:GridView ID="SqlDataSource2" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="SqlDataSource3" ForeColor="#333333" GridLines="None" style="margin-left:40px" DataKeyNames="id">
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
        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True" SelectCommand="SELECT * FROM [Favoritos]"></asp:SqlDataSource>
    </div>
</asp:Content>
