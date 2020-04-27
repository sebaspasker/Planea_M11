<%@ Page Title="" Language="C#" MasterPageFile="~/Default2.Master" AutoEventWireup="true" CodeBehind="Planea.aspx.cs" Inherits="planeaWeb.Planea" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="Registro.css" rel="stylesheet" />
    <div class="Registrarse_css1">
        <br />
        <h5 style="text-align: left; margin-left: 40px">Planea!</h5>
        <div style="text-align: left; margin-left: 40px">
            <asp:Label runat="server" ID="lista_planea"/>
            <br />
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
&nbsp;
            <asp:Button ID="PlaneaButton" runat="server" Height="23px" Text="Planea" Width="109px" />
            <br />

        </div>
    </div>
</asp:Content>
