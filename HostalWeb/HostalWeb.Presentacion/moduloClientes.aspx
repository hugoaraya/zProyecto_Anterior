<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="moduloClientes.aspx.cs" Inherits="HostalWeb.Presentacion.moduloClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Módulo Administración Clientes</h2>
      <div class="contenedor">
        <div class="box" >
            <h3>Registrar Usuario</h3>
                <a href="../templates/MantenedorUsuario.aspx">Mantenedor Usuario (completo)???</a><br />
                <a href="../templates/IngresarUsuario.aspx">Ingresar Usuario</a><br />
                <a href="../templates/ObtenerDatoUsuario.aspx">Obtener Dato Usuario</a><br />
                <a href="../templates/ObtenerListaUsuarios.aspx">Obtener Lista Usuario</a><br />
                <a href="../templates/ModificarUsuario.aspx">Modificar Usuario</a>
        </div>
        <div class="box" >
             <h3>Registrar Empresa</h3>
                <a href="../templates/MantenedorEmpresa.aspx">Mantenedor Empresa (completo)</a><br />
                <a href="../templates/IngresarEmpresa.aspx">Ingresar Empresa</a><br />
                <a href="../templates/ObtenerDatoEmpresa.aspx">Obtener Dato Empresa</a><br />
                <a href="../templates/ObtenerListaEmpresas.aspx">Obtener Lista Empresas</a><br />
                <a href="../templates/ModificarEmpresa.aspx">Modificar Empresa</a>
        </div>
        <div class="box" >
             <h3>Registrar Trabajador</h3>
                <a href="../templates/MantenedorTrabajador.aspx">Mantenedor Trabajador (completo)???</a><br />
                <a href="../templates/IngresarTrabajador.aspx">Ingresar Trabajador</a><br />
                <a href="../templates/ObtenerDatoTrabajador.aspx">Obtener Dato Trabajador</a><br />
                <a href="../templates/ObtenerListaTrabajadores.aspx">Obtener Lista Trabajadores</a><br />
                <a href="../templates/ModificarTrabajador.aspx">Modificar Trabajador</a>
        </div>
    </div>
</asp:Content>
