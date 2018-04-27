<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="moduloClientes.aspx.cs" Inherits="HostalWeb.Presentacion.moduloClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Modulo Administracion Clientes</h2>
      <div class="contenedor">
        <div class="box" >
            <h3>Registrar Cliente</h3>
                <a href="../templates/mantenedorCliente.aspx">Mantenedor Cliente (completo)???</a><br />
                <a href="../templates/ingresarCliente.aspx">Ingresar Cliente</a><br />
                <a href="../templates/obtenerDatoCliente.aspx">Obtener Dato Cliente</a><br />
                <a href="../templates/obtenerListaClientes.aspx">Obtener Lista Clientes</a><br />
                <a href="../templates/ModificarClientes.aspx">Modificar Cliente</a>
        </div>
        <div class="box" >
             <h3>Registrar Empresa</h3>
                <a href="../templates/mantenedorEmpresa.aspx">Mantenedor Empresa (completo)???</a><br />
                <a href="../templates/ingresarEmpresa.aspx">Ingresar Empresa</a><br />
                <a href="../templates/obtenerDatoEmpresa.aspx">Obtener Dato Empresa</a><br />
                <a href="../templates/obtenerListaEmpresas.aspx">Obtener Lista Empresas</a><br />
                <a href="../templates/ModificarEmpresa.aspx">Modificar Empresa</a>
        </div>
        <div class="box" >
             <h3>Registrar Trabajador</h3>
                <a href="../templates/mantenedorTrabajador.aspx">Mantenedor Trabajador (completo)???</a><br />
                <a href="../templates/ingresarTrabajador.aspx">Ingresar Trabajador</a><br />
                <a href="../templates/obtenerDatoTrabajador.aspx">Obtener Dato Trabajador</a><br />
                <a href="../templates/obtenerListaTrabajadores.aspx">Obtener Lista Trabajadores</a><br />
                <a href="../templates/ModificarTrabajador.aspx">Modificar Trabajador</a>
        </div>




    </div>
</asp:Content>
