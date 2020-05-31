<%@ Page Title="" Language="C#" MasterPageFile="~/MASTER/Default1.Master" AutoEventWireup="true" CodeBehind="Planea.aspx.cs" Inherits="planeaWeb.Planea" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../CSS/Registro.css" rel="stylesheet" />
    <div class="Registrarse_css1" style="margin-top: 20px">
        <br />
        <h5 style="text-align: left; margin-left: 40px">Planea!</h5>
        <div style="text-align: left; margin-left: 40px">
            <p class="label_lista">
                <asp:Label runat="server" ID="lista_planea"/>
            </p>
            <br />
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" Width="200px" >
                <asp:ListItem Text="-- Select Usuario --" Value="0"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <p>
                <asp:DropDownList ID="DropDownList2" runat="server" Width="200px">
                    <asp:ListItem Text="-- Select Plan --" Value="0"></asp:ListItem>
                </asp:DropDownList>
            </p>
            <p>
                &nbsp;</p>
            <p>
                <asp:DropDownList ID="DropDownList3" runat="server" Width="200px">
                    <asp:ListItem Text="-- Hora Inicio --" Value="0"></asp:ListItem>
                </asp:DropDownList>
            <p>
                &nbsp;</p>
            <p>
                <asp:DropDownList ID="DropDownList4" runat="server" Width="200px">
                    <asp:ListItem Text="-- Hora Fin --" Value="0"></asp:ListItem>
                </asp:DropDownList>
            </p>
            <p>
                &nbsp;</p>
            <asp:Calendar ID="Calendar1" runat="server" BackColor="#018ABD">
                <TitleStyle BackColor="#001B48" ForeColor="White" />
                <DayHeaderStyle ForeColor="White" BackColor="#001B48"/>
            </asp:Calendar>
            <br />
            <asp:Button ID="PlaneaButton" OnClick="PlaneaFunction" runat="server" Height="23px" Text="Planea" Width="109px" />
            <br />
            <p>
                <asp:Label runat="server" ID="errorPlanea" /> <br /> 
            </p>
        </div>
    </div>
</asp:Content>
