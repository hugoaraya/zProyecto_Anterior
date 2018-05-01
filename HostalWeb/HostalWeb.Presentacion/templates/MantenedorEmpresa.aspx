<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="MantenedorEmpresa.aspx.cs" Inherits="HostalWeb.Presentacion.templates.MantenedorEmpresa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Mantenedor Empresa</h2>

              <asp:Label ID="lbRut" runat="server" Text="Rut"></asp:Label>
              <asp:TextBox ID="txtRut" runat="server"></asp:TextBox>
              
        <br /><asp:Label ID="lbNombre" runat="server" Text="Nombre"></asp:Label>
              <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
              
        <br /><asp:Label ID="lbGiro" runat="server" Text="Giro"></asp:Label>
              <asp:TextBox ID="txtGiro" runat="server"></asp:TextBox>
              
        <br /><asp:Label ID="lbDireccion" runat="server" Text="Direccion"></asp:Label>
              <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
              
  

    <br /><br />
    <asp:Button ID="btnCreate" runat="server" Text="Ingresar"  Width="470px" OnClick="btnCreate_Click" />
    <br />
    <asp:Button ID="btnRead" runat="server" Text="Buscar" OnClick="btnRead_Click" Width="470px" />
    <br />
    <asp:Button ID="btnUpdate" runat="server" Text="Actualizar"  Width="470px" />
    <br />
    <asp:Button ID="btnlimpiar" runat="server"  Text="Limpiar Campos" Width="470px" OnClick="btnlimpiar_Click" />
    <br />
    <asp:Label ID="lblMessages" runat="server" Text=""></asp:Label>
    <br />


</asp:Content>
