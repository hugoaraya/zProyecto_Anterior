<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="ObtenerDatoEmpresa.aspx.cs" Inherits="HostalWeb.Presentacion.templates.ObtenerDatoEmpresa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <h2>Obtener Datos de Empresa</h2>

              <asp:Label ID="lbRut" runat="server" Text="Rut : "></asp:Label>
              <asp:TextBox ID="txtRut" runat="server"></asp:TextBox>
              
        <br /><asp:Label ID="lbNombre" runat="server" Text="Nombre : "></asp:Label>
              <asp:Label  ID="txtNombre" runat="server" Text=""></asp:Label>
              
        <br /><asp:Label ID="lbGiro" runat="server" Text="Giro : "></asp:Label>
              <asp:Label  ID="txtGiro" runat="server" Text=""></asp:Label>
              
        <br /><asp:Label ID="lbDireccion" runat="server" Text="Direccion : "></asp:Label>
              <asp:Label  ID="txtDireccion" runat="server" Text=""></asp:Label>
              
  

    <br /><br />
    <asp:Button ID="btnRead" runat="server" Text="Buscar" Width="470px" OnClick="btnRead_Click" />
    <br />
    <asp:Button ID="btnlimpiar" runat="server"  Text="Limpiar Campos" Width="470px" OnClick="btnlimpiar_Click" />
    <br />
    <asp:Label ID="lblMessages" runat="server" Text=""></asp:Label>
    <br />


</asp:Content>
