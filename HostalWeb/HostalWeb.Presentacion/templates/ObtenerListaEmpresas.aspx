<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="ObtenerListaEmpresas.aspx.cs" Inherits="HostalWeb.Presentacion.templates.ObtenerListaEmpresas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Listado de Empresas: </h2>
    <asp:GridView ID="GVEmpresas" runat="server" AllowPaging="True" OnPageIndexChanging="GVEmpresas_PageIndexChanging" HorizontalAlign="Center"></asp:GridView>
</asp:Content>
