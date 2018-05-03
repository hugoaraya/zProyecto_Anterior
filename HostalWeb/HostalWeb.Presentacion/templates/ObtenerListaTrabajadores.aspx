<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="ObtenerListaTrabajadores.aspx.cs" Inherits="HostalWeb.Presentacion.ObtenerListaTrabajadores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Listado de Trabajadores: </h2>
    <asp:GridView ID="GVTrabajadores" runat="server" AllowPaging="True" OnPageIndexChanging="GVTrabajadores_PageIndexChanging" HorizontalAlign="Center"></asp:GridView>
</asp:Content>
